using Graphics_pro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRace
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            Task.Run(() =>
            {
                System.Media.SoundPlayer player =
                    new System.Media.SoundPlayer("s.wav");
                player.Play();
            });
        }

        private void exitBut_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void StartBut_Click(object sender, EventArgs e)
        {
            new SelectCar().Show();
            global.mainForm = this;
            this.Hide();
        }
    }
}
