using System;
using MaterialSkin.Controls;

namespace ChartsApp
{
    public partial class FormContinuous : MaterialForm
    {
        public FormContinuous()
        {
            InitializeComponent();
        }

        private void FormContinuous_Load(object sender, EventArgs e)
        {
            CityRepository cityRepo = CityRepository.getInstance();

            /**
             valor  mínimo [OK] 
             valor  máximo [OK]  
             amplitude  [OK] 
             média [OK]
             mediana [OK]   
             moda  [OK]  
             variância [OK]
             desvio padrão [OK]
             coeficiente de variação
            **/

            //Showing Data:
            lblMaxValue.Text += String.Format("{0}: [{1}, {2}]", cityRepo.GetMax().Population.ToString("0,0"), cityRepo.GetMax().Name, cityRepo.GetMax().State);
            lblMinValue.Text += String.Format("{0}: [{1}, {2}]", cityRepo.GetMin().Population.ToString("0,0"), cityRepo.GetMin().Name, cityRepo.GetMin().State);
            lblAverageValue.Text += cityRepo.GetAverage().ToString("0,0.00");
            lblModa.Text += cityRepo.GetModa().ToString("0,0");
            lblMediana.Text += cityRepo.GetMediana().ToString("0,0.00");
            lblAmplitude.Text += cityRepo.GetAmplitude().ToString("0,0");
            lblVariancia.Text += cityRepo.GetVariancia().ToString("0,0.00");
            lblDesvioPadrao.Text += cityRepo.GetDesvioPadrao().ToString("0,0.00");
            lblCoeficienteVariacao.Text += cityRepo.GetCoeficienteVariacao().ToString("p");
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
