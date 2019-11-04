﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA191104SAVANNASIM
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        private void btnPopulateSavanna_Click(object sender, EventArgs e)
        {
            var frm = new FrmSavanna((int)nudSor.Value, (int)nudOszlop.Value);
            frm.ShowDialog();
        }
    }
}
