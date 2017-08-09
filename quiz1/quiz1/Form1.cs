using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] name = new string[20];
        string[] surname = new string[20];
        string[] no = new string[20];

        int i = 0;
        private void btnSave_Click(object sender, EventArgs e)
        {



            name[i] = txtName.Text.Trim();
            surname[i] = txtSurname.Text.Trim();
            no[i] = txtNo.Text.Trim();


            txtName.Clear();
            txtSurname.Clear();
            txtNo.Clear();

            //lbDisplay.Items.Add(name[i] +"       "  +surname[i]+ "            " + no[i]);
            lbDisplay.Items.Add($"{name[i]} {surname[i]} {no[i]}");
            i++;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchName;
            int buldum = 0;
            searchName = txtSearch.Text;

            for(int y=0; y<i; y++ )
            {
                if (searchName.Trim().ToLower() == name[y].ToLower())
                {
                    lbDisplay.SelectedIndex = y;
                    buldum++;
                }
            }
            if (buldum==0)
            {
                MessageBox.Show("Aradığınız isim data da bulunmamaktadır ! ");
            }
            txtSearch.Text = "";
        }

        private void btnSurname_Click(object sender, EventArgs e)
        {
            string searchSurname;
            int buldum = 0;
            searchSurname = txtSearch.Text;

            for (int y = 0; y < i; y++)
            {
                if (searchSurname == surname[y])
                {
                    lbDisplay.SelectedIndex = y;
                    buldum++;
                }
            }
            if (buldum == 0)
            {
                MessageBox.Show("Aradığınız isim data da bulunmamaktadır ! ");
            }
            txtSearch.Text = "";
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            string numara;
            int buldum = 0;
            numara = txtSearch.Text;

            for (int y = 0; y < i; y++)
            {
                if (numara == no[y])
                {
                    lbDisplay.SelectedIndex = y;
                    buldum++;
                }
            }
            if (buldum == 0)
            {
                MessageBox.Show("Aradığınız isim data da bulunmamaktadır ! ");
            }
            txtSearch.Text = "";
        }
    }
}
