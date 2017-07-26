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

        private void btnNot_Click(object sender, EventArgs e)
        {
            try
            {
                int not = Convert.ToInt32(txtDeger.Text);

                if (not < 0)
                {
                    MessageBox.Show("0'dan küçük değer giremezsiniz!");
                }
                else if (not > 100)
                {
                    MessageBox.Show("100 den büyük değer giremezsiniz");
                }
                else
                {
                    MessageBox.Show("Hatasız not girişi yaptınız . ");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Not giremiyeceksen daha da burda olma ! ");
            }
            
        }

        private void btnTek_Click(object sender, EventArgs e)
        {
            try
            {
                int tek = Convert.ToInt32(txtDeger.Text);

                //string strSayi = sayi + "";  ÖNEMLİ : Bir int değeri bir string ile toplarsak int değeri string e çevrilmiş olur. 
                //MessageBox.Show(strSayi);

                if (tek %2 == 0)
                {
                    MessageBox.Show("Girdiğiniz sayı çift!!");
                    this.Text = tek + "Çifttir !";
                }
                else
                {
                    this.Text = tek + "Tektir ! ";
                    MessageBox.Show("Girdiğiniz sayı tek!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Length >= 8)
            {
                MessageBox.Show("Giriş onaylandı!");
            }
            else
            {
                MessageBox.Show("Daha uzun bir şifre girmeniz gerekiyor! ");
                txtDeger.BackColor = Color.Green;
            }
        }

        private void txtLogin_Enter(object sender, EventArgs e)
        {
            txtDeger.BackColor = Color.Red;
            txtDeger.ForeColor = Color.White;
        }
    }
}
