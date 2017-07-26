using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace switchCase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cbMevsim.Items.Add("Kış");
            cbMevsim.Items.Add("İlkbahar");
            cbMevsim.Items.Add("Yaz");
            cbMevsim.Items.Add("Sonbahar");
            
        }

        private void cbMevsim_SelectedIndexChanged(object sender, EventArgs e)
        {
            //1.Yol
            string mevsim = cbMevsim.SelectedItem.ToString();
            MessageBox.Show(mevsim);

            //2.YOL
            int index = cbMevsim.SelectedIndex;
            MessageBox.Show(cbMevsim.Items[index].ToString());

            switch (mevsim)
            {
                case "Kış": MessageBox.Show("Aralık\n Ocak\n Şubat\n"); break;
                case "İlkbahar": MessageBox.Show("Mart\n Nisan\n Mayıs\n"); break;
                case "Yaz": MessageBox.Show("Haziran\n Temmuz\n Ağustos\n"); break;
                case "Sonbahar": MessageBox.Show("Eylül\n Ekim\n Kasım\n"); break;

                default:
                    MessageBox.Show("Hatalı seçim " );
                    break;
            }
        }

    }
}
