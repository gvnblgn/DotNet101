using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listCollection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> numbers = new List<int>();

        private void Form1_Load(object sender, EventArgs e)
        {
            
            numbers.Add(5);
            numbers.AddRange(new List<int>(3, 8, 10));
            numbers.AddRange(new int[](45, 55, 65));

           
        }

        void ListBoxVeriEklemeInt(List<int> ());
    }
}
