using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concurrencias._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void BtnCharge_Click(object sender, EventArgs e)
        {
            LoadingGIF.Visible = true;
            await esperar();
            LoadingGIF.Visible = false;
        }

        private async Task esperar()
        {
            await Task.Delay(5000);
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
