using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
