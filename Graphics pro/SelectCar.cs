using Graphics_pro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CarRace
{
    public partial class SelectCar : Form
    {
        public SelectCar()
        {
            InitializeComponent();
        }

        private void GoBTN_Click(object sender, EventArgs e)
        {
            if(global.gameForm == null)
                new GameForm().Show();
            else
            {
                global.gameForm.Show();
            }
            this.Close();
        }

        private void exitBut_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void car1RDBTN_CheckedChanged(object sender, EventArgs e)
        {
            if (car1RDBTN.Checked)
                GameControl.selectedCarIndex = 0;
        }
        private void car2RDBTN_CheckedChanged(object sender, EventArgs e)
        {
            if (car2RDBTN.Checked)
                GameControl.selectedCarIndex = 1;
        }
        private void car3RDBTN_CheckedChanged(object sender, EventArgs e)
        {
            if (car3RDBTN.Checked)
                GameControl.selectedCarIndex = 2;
        }
    }
}
