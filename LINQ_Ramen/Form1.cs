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

namespace LINQ_Ramen
{
    public partial class Form1 : Form
    {
        private List<Country> countries = new List<Country>();
        private List<Ramen> ramens = new List<Ramen>();

        public Form1()
        {
            InitializeComponent();
            LoadData("ramen.csv");
            countryList.DisplayMember = "Name";
            GetCountries();
        }

        private void LoadData(string fileName)
        {
            StreamReader sr = new StreamReader(fileName, Encoding.Default);
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                var sor = sr.ReadLine().Split(';');

                var sorCountry = sor[2];
                var currCountry = AddCountry(sorCountry);
                var ramen = new Ramen()
                {
                    Brand = sor[0],
                    Name = sor[1],
                    ID = ramens.Count + 1,
                    CountryFK = currCountry.ID,
                    Country = currCountry,
                    Stars = Convert.ToDouble(sor[3])
                };
                ramens.Add(ramen);

            }
        }

        private Country AddCountry(string sorCountry)
        {
            var currentCountry = (from x in countries
                                  where x.Name.Equals(sorCountry)
                                  select x).FirstOrDefault();

            if (currentCountry == null)
            {
                currentCountry = new Country()
                {
                    ID = countries.Count + 1,
                    Name = sorCountry
                };
                countries.Add(currentCountry);
            }
            return currentCountry;
        }

        private void GetCountries()
        {
            var countriesFiltered = from x in countries
                                where x.Name.Contains(filterBox.Text)
                                orderby x.Name
                                select x;
            countryList.DataSource = countriesFiltered.ToList();
        }

        private void filterBox_TextChanged(object sender, EventArgs e)
        {
            GetCountries();
        }

        private void countryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var countrySelected = (Country)((ListBox)sender).SelectedItem;

            if (countrySelected == null)
                return;

            var RamenByCountry = from r in ramens
                                where r.CountryFK == countrySelected.ID
                                select r;

            var RamenGrouped = from r in RamenByCountry
                                group r.Stars by r.Brand into g
                                select new
                                {
                                    Márkanév = g.Key,
                                    Értékátlag = Math.Round(g.Average(), 2)
                                };

            var RatingOrderedGroups = from g in RamenGrouped
                                orderby g.Értékátlag descending
                                select g;

            RamenDGW.DataSource = RatingOrderedGroups.ToList();
        }
    }
}
