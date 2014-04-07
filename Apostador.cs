using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Apostador
{
    public partial class Apostador : Form
    {
        public Apostador()
        {
            InitializeComponent();
        }

        private void Apostador_Load(object sender, EventArgs e)
        {
            moneyCBox.SelectedIndex = 0;
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (btnAction.Text == "Comenzar")
            {
                btnAction.Text = "Detener";
            }
            else
            {
                btnAction.Text = "Comenzar";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}