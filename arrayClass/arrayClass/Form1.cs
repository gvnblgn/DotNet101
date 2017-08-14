﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arrayClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] sehirler =
        {
            "İstanbul",
            "İzmir",
            "Ankara",
            "Konya",
            "Bursa",
            "Adana",
            "Trabzon"
        };
        private void btnClear_Click(object sender, EventArgs e)
        {
            Array.Clear(sehirler, 1, 1);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            string[] ornek = new string[4];
            Array.Copy(sehirler, 3, ornek, 0, 2);
        }

        private void btnLastIndex_Click(object sender, EventArgs e)
        {
            int index = Array.LastIndexOf(sehirler, "Adana");
            //int firstIndex = Array.IndexOf(sehirler, "Trabzon");
        }

        private void btnIndex_Click(object sender, EventArgs e)
        {
            int index = Array.IndexOf(sehirler, "İzmir");
        }
    }
}
