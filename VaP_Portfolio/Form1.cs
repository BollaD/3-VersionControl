using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VaP_Portfolio.Entities;

namespace VaP_Portfolio
{
    public partial class Form1 : Form
    {
        List<Tick> Ticks;
        PortfolioEntities context = new PortfolioEntities();
        List<PortfolioItem> Portfolio = new List<PortfolioItem>();
        List<decimal> Nyereségek = new List<decimal>();

        public Form1()
        {
            InitializeComponent();
            Ticks = context.Ticks.ToList();
            Tick_DGW.DataSource = Ticks;
            CreatePortfolio();

            //VaR kiszámítása
            int intervalum = 30;
            DateTime kezdőDátum = (from x in Ticks select x.TradingDay).Min();
            DateTime záróDátum = new DateTime(2016, 12, 30);
            TimeSpan z = záróDátum - kezdőDátum;
            for (int i = 0; i < z.Days - intervalum; i++)
            {
                decimal ny = GetPortfolioValue(kezdőDátum.AddDays(i + intervalum))
                           - GetPortfolioValue(kezdőDátum.AddDays(i));
                Nyereségek.Add(ny);
                Console.WriteLine(i + " " + ny);
            }

            var nyereségekRendezve = (from x in Nyereségek
                                      orderby x
                                      select x)
                                        .ToList();
            //MessageBox.Show(nyereségekRendezve[nyereségekRendezve.Count() / 5].ToString());
        }

        private void CreatePortfolio()
        {
            Portfolio.Add(new PortfolioItem() { Index = "OTP", Volume = 10 });
            Portfolio.Add(new PortfolioItem() { Index = "ZWACK", Volume = 10 });
            Portfolio.Add(new PortfolioItem() { Index = "ELMU", Volume = 10 });

            Portfolio_DGW.DataSource = Portfolio;
        }

        private decimal GetPortfolioValue(DateTime date)
        {
            decimal value = 0;
            foreach (var item in Portfolio)
            {
                var last = (from x in Ticks
                            where item.Index == x.Index.Trim()
                               && date <= x.TradingDay
                            select x)
                            .First();
                value += (decimal)last.Price * item.Volume;
            }
            return value;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = Application.StartupPath;
            sfd.Filter = "CSV|*.csv";
            sfd.DefaultExt = "csv";
            sfd.AddExtension = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(sfd.FileName, true, Encoding.UTF8))
                {
                    sw.WriteLine($"Időszak;Nyereség");
                    int i = 0;
                    foreach (decimal nyereseg in Nyereségek)
                    {
                        sw.WriteLine($"{i};{nyereseg}");
                        i++;
                    }
                }
            }
        }
    }
}
