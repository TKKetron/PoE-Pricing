﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POE_Pricing
{
    public partial class HarvestMemoryForm : Form
    {
        Form main;
        public HarvestMemoryForm(Form main)
        {
            InitializeComponent();
            this.main = main;
        }
    }
}