using System;
using System.Data;
using System.Windows.Forms.DataVisualization.Charting;
using MaterialSkin.Controls;

namespace ChartsApp
{
    public partial class FormSeries : MaterialForm
    {
        public FormSeries()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void FormSeries_Load(object sender, EventArgs e)
        {
            CitySeriesRepository citySeriesRepo = CitySeriesRepository.getInstance();
            CityRepository citySeries = CityRepository.getInstance();

            /**
             média         [OK]
             moda          [OK]   
             mediana       [OK]   
             variância     [OK] 
             desvio padrão [OK] 
             coeficiente de variação [OK]
            **/

            lblMedia.Text += citySeriesRepo.GetMedia().ToString("0,0.00");
            lblMediana.Text += citySeriesRepo.GetMediana().ToString("0,0.00");
            lblModa.Text += citySeriesRepo.GetModa().ToString("0,0.00");
            lblvariancia.Text += citySeriesRepo.GetVariancia().ToString("0,0.00");
            lblDesvioPadrao.Text += citySeriesRepo.GetDesvioPadrao().ToString("0,0.00");
            lblCoeficienteVariacao.Text += citySeriesRepo.GetCoeficienteVariacao().ToString("p");
            
            // Table:

            DataTable tabela = CriarDataTable();
            dgv.DataSource = tabela;

            // Chart:
            var seriesData = citySeriesRepo.Series;

            this.chartSeries.Series.Clear();
            this.chartSeries.Palette = ChartColorPalette.EarthTones;

            this.chartSeries.Titles.Add("Frequencia da Populacao de Municipios");

            foreach (var entry in seriesData)
            {
                Series series = this.chartSeries.Series.Add(entry.Key);
                series.Points.Add(entry.Value.Item1);
            }

            //Comparacao:
            lblMediaComparation.Text = citySeries.GetAverage().ToString() + (citySeries.GetAverage() > citySeriesRepo.GetMedia() ? " > " : " < ")
                + citySeriesRepo.GetMedia();

            lblMedianaComparation.Text = citySeries.GetMediana().ToString() + (citySeries.GetMediana() > citySeriesRepo.GetMediana() ? " > " : " < ")
                + citySeriesRepo.GetMediana();
        }

        private DataTable CriarDataTable()
        {
            DataTable dtb_Alunos = new DataTable();
            CitySeriesRepository citySeriesRepo = CitySeriesRepository.getInstance();
            var seriesData = citySeriesRepo.Series;

            dtb_Alunos.Columns.Add("Serie", typeof(string));
            dtb_Alunos.Columns.Add("Frequencia", typeof(int));
            dtb_Alunos.Columns.Add("Media", typeof(int));
            dtb_Alunos.Columns.Add("Frequencia Relativa", typeof(float));
            dtb_Alunos.Columns.Add("Frequencia Acumulada", typeof(int));
            dtb_Alunos.Columns.Add("Frequencia Acumulada Relativa", typeof(float));

            float ammount = 0;
            float total = (float)citySeriesRepo.SomatorioFrequencia();

            foreach (var entry in seriesData)
            {
                ammount += entry.Value.Item1;
      
                dtb_Alunos.Rows.Add(entry.Key, entry.Value.Item1, entry.Value.Item2, ((float)entry.Value.Item1 / total), ammount, ((float)ammount/ total));
            }

            return dtb_Alunos;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
