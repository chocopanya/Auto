﻿using System;
using System.Windows.Forms;
using System.Threading;


namespace Koleso
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        
        
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_Click_1(object sender, EventArgs e)
        {
            Form2 Reg = new Form2();
            Reg.ShowDialog();
            

        }
    }
}