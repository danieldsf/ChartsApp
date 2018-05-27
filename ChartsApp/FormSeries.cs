using System;
using MaterialSkin.Controls;

namespace ChartsApp
{
    public partial class FormSeries : MaterialForm
    {
        public FormSeries()
        {
            InitializeComponent();
        }

        private void FormSeries_Load(object sender, EventArgs e)
        {
            CitySeriesRepository citySeriesRepo = CitySeriesRepository.getInstance();
            
            /**
             média [OK]
             mediana []   
             moda [OK]   
             variância [] 
             desvio padrão [] 
             coeficiente de variação []
            **/

            lblMedia.Text += citySeriesRepo.GetMedia().ToString("0,0.00");
            lblMediana.Text += citySeriesRepo.GetMediana().ToString("0,0.00");
            lblModa.Text += citySeriesRepo.GetModa().ToString("0,0.00");
            lblvariancia.Text += citySeriesRepo.Getvariancia().ToString("0,0.00");
            lblDesvioPadrao.Text += citySeriesRepo.GetDesvioPadrao().ToString("0,0.00");
            lblCoeficienteVariacao.Text += citySeriesRepo.GetCoeficienteVariacao().ToString("0,0.00");
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHistograma_Click(object sender, EventArgs e)
        {
            //Gerar Grafico:
            FormChart frmChart = new FormChart();
            frmChart.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Ver distribuicao de frequencia:
            FormTable frmTable = new FormTable();
            frmTable.Show();
        }
    }
}
