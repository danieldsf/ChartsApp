namespace ChartsApp
{
    partial class FormContinuous
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAverageValue = new System.Windows.Forms.Label();
            this.lblMinValue = new System.Windows.Forms.Label();
            this.lblMaxValue = new System.Windows.Forms.Label();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.lblModa = new System.Windows.Forms.Label();
            this.lblMediana = new System.Windows.Forms.Label();
            this.lblVariancia = new System.Windows.Forms.Label();
            this.lblDesvioPadrao = new System.Windows.Forms.Label();
            this.lblAmplitude = new System.Windows.Forms.Label();
            this.lblCoeficienteVariacao = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCoeficienteVariacao);
            this.panel1.Controls.Add(this.lblAmplitude);
            this.panel1.Controls.Add(this.lblDesvioPadrao);
            this.panel1.Controls.Add(this.lblVariancia);
            this.panel1.Controls.Add(this.lblMediana);
            this.panel1.Controls.Add(this.lblModa);
            this.panel1.Controls.Add(this.lblAverageValue);
            this.panel1.Controls.Add(this.lblMinValue);
            this.panel1.Controls.Add(this.lblMaxValue);
            this.panel1.Location = new System.Drawing.Point(12, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 247);
            this.panel1.TabIndex = 0;
            // 
            // lblAverageValue
            // 
            this.lblAverageValue.AutoSize = true;
            this.lblAverageValue.Location = new System.Drawing.Point(23, 56);
            this.lblAverageValue.Name = "lblAverageValue";
            this.lblAverageValue.Size = new System.Drawing.Size(42, 13);
            this.lblAverageValue.TabIndex = 2;
            this.lblAverageValue.Text = "Media: ";
            // 
            // lblMinValue
            // 
            this.lblMinValue.AutoSize = true;
            this.lblMinValue.Location = new System.Drawing.Point(23, 32);
            this.lblMinValue.Name = "lblMinValue";
            this.lblMinValue.Size = new System.Drawing.Size(73, 13);
            this.lblMinValue.TabIndex = 1;
            this.lblMinValue.Text = "Valor Minimo: ";
            // 
            // lblMaxValue
            // 
            this.lblMaxValue.AutoSize = true;
            this.lblMaxValue.Location = new System.Drawing.Point(23, 9);
            this.lblMaxValue.Name = "lblMaxValue";
            this.lblMaxValue.Size = new System.Drawing.Size(76, 13);
            this.lblMaxValue.TabIndex = 0;
            this.lblMaxValue.Text = "Valor Maximo: ";
            // 
            // btnGoBack
            // 
            this.btnGoBack.Location = new System.Drawing.Point(191, 347);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(75, 23);
            this.btnGoBack.TabIndex = 1;
            this.btnGoBack.Text = "Fechar";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // lblModa
            // 
            this.lblModa.AutoSize = true;
            this.lblModa.Location = new System.Drawing.Point(23, 83);
            this.lblModa.Name = "lblModa";
            this.lblModa.Size = new System.Drawing.Size(40, 13);
            this.lblModa.TabIndex = 3;
            this.lblModa.Text = "Moda: ";
            // 
            // lblMediana
            // 
            this.lblMediana.AutoSize = true;
            this.lblMediana.Location = new System.Drawing.Point(23, 111);
            this.lblMediana.Name = "lblMediana";
            this.lblMediana.Size = new System.Drawing.Size(54, 13);
            this.lblMediana.TabIndex = 4;
            this.lblMediana.Text = "Mediana: ";
            // 
            // lblVariancia
            // 
            this.lblVariancia.AutoSize = true;
            this.lblVariancia.Location = new System.Drawing.Point(23, 137);
            this.lblVariancia.Name = "lblVariancia";
            this.lblVariancia.Size = new System.Drawing.Size(57, 13);
            this.lblVariancia.TabIndex = 5;
            this.lblVariancia.Text = "Variancia: ";
            // 
            // lblDesvioPadrao
            // 
            this.lblDesvioPadrao.AutoSize = true;
            this.lblDesvioPadrao.Location = new System.Drawing.Point(23, 168);
            this.lblDesvioPadrao.Name = "lblDesvioPadrao";
            this.lblDesvioPadrao.Size = new System.Drawing.Size(83, 13);
            this.lblDesvioPadrao.TabIndex = 6;
            this.lblDesvioPadrao.Text = "Desvio Padrao: ";
            // 
            // lblAmplitude
            // 
            this.lblAmplitude.AutoSize = true;
            this.lblAmplitude.Location = new System.Drawing.Point(23, 193);
            this.lblAmplitude.Name = "lblAmplitude";
            this.lblAmplitude.Size = new System.Drawing.Size(59, 13);
            this.lblAmplitude.TabIndex = 7;
            this.lblAmplitude.Text = "Amplitude: ";
            // 
            // lblCoeficienteVariacao
            // 
            this.lblCoeficienteVariacao.AutoSize = true;
            this.lblCoeficienteVariacao.Location = new System.Drawing.Point(23, 221);
            this.lblCoeficienteVariacao.Name = "lblCoeficienteVariacao";
            this.lblCoeficienteVariacao.Size = new System.Drawing.Size(126, 13);
            this.lblCoeficienteVariacao.TabIndex = 8;
            this.lblCoeficienteVariacao.Text = "Coeficiente de Variação: ";
            // 
            // FormContinuous
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 382);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.panel1);
            this.Name = "FormContinuous";
            this.Text = "Dados continuos";
            this.Load += new System.EventHandler(this.FormContinuous_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Label lblMaxValue;
        private System.Windows.Forms.Label lblAverageValue;
        private System.Windows.Forms.Label lblMinValue;
        private System.Windows.Forms.Label lblModa;
        private System.Windows.Forms.Label lblMediana;
        private System.Windows.Forms.Label lblDesvioPadrao;
        private System.Windows.Forms.Label lblVariancia;
        private System.Windows.Forms.Label lblCoeficienteVariacao;
        private System.Windows.Forms.Label lblAmplitude;
    }
}