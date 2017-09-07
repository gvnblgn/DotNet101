using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciKayit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        void Clean()
        {
            txtName.Clear();
            txtSurname.Clear();
            txtNumber.Clear();
            txtDepartment.Clear();
            dtBirthday.Refresh();
            dtRegistration.Refresh();
        }

        void ListShow()
        {
            lbOgrenci.Items.Clear();

            foreach (var student in ogrenci)
            {
                lbOgrenci.Items.Add(student);
            }
        }

        int CalculateAge(DateTimePicker dt)
        {
            int bugün = DateTime.Now.Year;
            int alinanTarih = dt.Value.Year;
            return bugün - alinanTarih;
        }

        bool NumberInquiry(string numara)
        {
            var result = ogrenci.FirstOrDefault(ogr => ogr.number.ToLower() == numara.ToLower());
            if (result != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        List<Student> ogrenci = new List<Student>();

        private void btnSave_Click(object sender, EventArgs e)
        {
            int yas = 0;
            Student person = new Student();
            person.name = txtName.Text.ToUpper().Trim();
            person.surname = txtSurname.Text.ToUpper().Trim();
            person.number = txtNumber.Text.ToUpper().Trim();
            person.department = txtDepartment.Text.ToUpper().Trim();
            person.birthday = dtBirthday.Value;
            person.registration = dtRegistration.Value;
            yas = CalculateAge(dtBirthday);
            if (!NumberInquiry(person.number) && yas>17)
            {
                ogrenci.Add(person);
                MessageBox.Show("Student is registrated successfully.");
            }
            else
            {
                MessageBox.Show("Student is not registrated ! \n Control number and birthday please .");
            }
                        ListShow();
            Clean();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(lbOgrenci.SelectedIndex== -1)
            {
                MessageBox.Show("Please select student from the list !");
            }
            else
            {
                Student stdnt = (Student)lbOgrenci.SelectedItem;
                var updateStudent = ogrenci.FirstOrDefault(x => x.number.ToUpper() == stdnt.number.ToUpper());
                updateStudent.name = txtName.Text;
                updateStudent.surname = txtSurname.Text;
                updateStudent.number = txtNumber.Text;
                updateStudent.department = txtDepartment.Text;
                updateStudent.birthday = dtBirthday.Value;
                updateStudent.registration = dtRegistration.Value;
                ListShow();
                Clean();
                MessageBox.Show("Information is updated !");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
                Student stdnt = (Student)lbOgrenci.SelectedItem;
                ogrenci.Remove(stdnt);
                ListShow();
                Clean();

        }

        private void lbOgrenci_Click(object sender, EventArgs e)
        {
            try
            {
                Student stdnt = (Student)lbOgrenci.SelectedItem;
                txtName.Text = stdnt.name;
                txtSurname.Text = stdnt.surname;
                txtNumber.Text = stdnt.number;
                txtDepartment.Text = stdnt.department;
                dtBirthday.Value = stdnt.birthday;
                dtRegistration.Value = stdnt.registration;
            }
            catch (Exception)
            {
            }
        }
    }
}
