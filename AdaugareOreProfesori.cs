﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elaborare_orarii_profesori
{
    public partial class AdaugareOreProfesoriForm : Form
    {
        public AdaugareOreProfesoriForm()
        {
            InitializeComponent();
        }

        private void comboZiSaptamana_SelectedIndexChanged(object sender, EventArgs e)
        {
            selItem.Text = comboZiSaptamana.Text;
        }
    }
}
