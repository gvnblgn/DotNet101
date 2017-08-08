using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace array2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < arabalar.Length; i++)
            {
                cbArabalar.Items.Add(i);
            }
        }

        string[] arabalar =
        {
            "Mazda",
            "Renault",
            "Porsche",
            "Mercedes",
            "BMW",
            "Bugatti",
            "Honda",
            "Tofaş",
            "Opel",
            "Toyota",
            "Ford",
            "Yavuz"
        };

        private void btnSonEleman_Click(object sender, EventArgs e)
        {
            MessageBox.Show($" Son Eleman : {arabalar[arabalar.Length-1]} ");
        }

        private void cbArabalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = int.Parse(cbArabalar.SelectedItem.ToString());
            //MessageBox.Show($"seçilen araç {arabalar[index]} " );
            Text = $"Seçilen Araç : {arabalar[index] } " ;
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int index = rnd.Next(0, 12);
            Text = $"Random Araç : {arabalar[index] } "; 
        }

        int[] sayilar = { 12, 23, 34, 45, 56 };
        private void btnEkleTopla_Click(object sender, EventArgs e)
        {

        }
    }
}
