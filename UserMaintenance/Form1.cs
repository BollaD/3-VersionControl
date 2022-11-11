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
using UserMaintenance.Entities;

namespace UserMaintenance
{
    public partial class Form1 : Form
    {
        BindingList<User> users = new BindingList<User>();

        public Form1()
        {
            InitializeComponent();
            TopLbl.Text = ProjectResource.FullName;
            BottomButton.Text = ProjectResource.Add;
            SmallButton.Text = ProjectResource.Write;

            LeftListbox.DataSource = users;
            LeftListbox.ValueMember = "ID";
            LeftListbox.DisplayMember = "FullName";
        }

        private void BottomButton_Click(object sender, EventArgs e)
        {
            var u = new User()
            {
                FullName = TopTextBox.Text,
            };
            users.Add(u);
        }

        private void SmallButton_Click(object sender, EventArgs e)
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
                    foreach (User u in users)
                    {
                        sw.WriteLine($"{u.ID};{u.FullName}");
                    }
                }
            }
        }
    }
}
