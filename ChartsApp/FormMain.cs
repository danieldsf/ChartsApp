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
        public CityRepository cityRepo = CityRepository.getInstance();

        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Console.WriteLine(this.cityRepo.GetCount());
        }

        private void btnContinuous_Click(object sender, EventArgs e)
        {
            FormContinuous frmContinuous = new FormContinuous();
            frmContinuous.Show();
        }

        private void btnSeries_Click(object sender, EventArgs e)
        {
            FormSeries frmSeries = new FormSeries();
            frmSeries.Show();
        }
    }
}
