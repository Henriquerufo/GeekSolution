﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class FrmCaixaCartaoDebito : Form
    {
        public String Retorno
        {
            get
            {
                return txtCartaoDebito.Text;
            }
        }
        public FrmCaixaCartaoDebito()
        {
            InitializeComponent();
        }

        private void txtDinheiro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Close();
            }
        }
    }
}
