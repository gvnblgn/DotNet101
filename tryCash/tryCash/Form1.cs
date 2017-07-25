using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tryCash
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDeger_Click(object sender, EventArgs e)
        {
            long gelenDeger = long.Parse(txtDeger.Text);
            //long gelenDeger = Convert.ToInt64(txtDeger.Text);

            MessageBox.Show("Tebrikler, Iphone 8s plus kazandınız!");
        }


        /* En sol gri şeritte bir satır belirlenerek break point koyuyoruz.
         * programı çalıştırdıktan sonra F10 tuşuyla adım adım ilerleyebiliyorsun.
         */

        private void btnKontrol_Click(object sender, EventArgs e)
        {
            try
            {
                //Hata riski olan kodların yazıldığı alan
                long gelenDeger = Convert.ToInt64(txtDeger.Text);
                MessageBox.Show("Tebrikler, Iphone 8s plus kazandınız!");


            }
            catch (Exception hata)
            {
                //Hatalı işlem yapıldığında çalışan kod
                //MessageBox.Show("Bir telefon numarası bile giremiyosun !! ");

                MessageBox.Show(hata.Message);

            }
        }

        private void btnFinal_Click(object sender, EventArgs e)
        {
            try
            {
                long gelenDeger = Convert.ToInt64(txtDeger.Text);
                MessageBox.Show("Tebrikler Iphone 8s plus kazandınız!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Hatasız kul olmaz, ben her türlü çalışırım ! ");
            }
        }
    }
}
