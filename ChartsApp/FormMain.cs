using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChartsApp;
using MaterialSkin.Controls;

namespace ChartsApp
{
    public partial class Main : MaterialForm
    {
        private FormContinuous frmContinuous;
        private FormSeries frmSeries;

        public Main()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.frmContinuous = new FormContinuous();
            this.frmSeries = new FormSeries();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            this.frmContinuous = new FormContinuous();
            this.frmContinuous.Show();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            this.frmSeries = new FormSeries();
            this.frmSeries.Show();
        }
    }
}
