﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsDiary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var path = $@"{Path.GetDirectoryName(Application.ExecutablePath)}\..\NowyPlik2.txt";

            File.AppendAllText(path, "Akademia .NET\n");
            var text = File.ReadAllText(path);

            MessageBox.Show(text);
            MessageBox.Show("Test programu", "Tytuł programu", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }
    }
}
