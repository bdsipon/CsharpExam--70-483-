﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassessAndObjectExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee e1 = new Employee();
        

            string p = e1.promote("Sipon","Hossain",4);
            MessageBox.Show(p);

        }
    }

    public class Employee
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int Seniority { get; set; }

        public string promote( string first, string last, int seniority )
        {
            first = firstName;
            last = lastName;
            Seniority = Seniority;
            return "{1}{2}{3}Employee has been promoted";

        }
        public string AnnualReview()
        {
            return "Annual review completed";
        }
    }
}
