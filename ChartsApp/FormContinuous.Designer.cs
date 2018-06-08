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
            this.pnlContinuos = new System.Windows.Forms.Panel();
            this.lblCoeficienteVariacao = new MaterialSkin.Controls.MaterialLabel();
            this.lblAmplitude = new MaterialSkin.Controls.MaterialLabel();
            this.lblDesvioPadrao = new MaterialSkin.Controls.MaterialLabel();
            this.lblVariancia = new MaterialSkin.Controls.MaterialLabel();
            this.lblMediana = new MaterialSkin.Controls.MaterialLabel();
            this.lblModa = new MaterialSkin.Controls.MaterialLabel();
            this.lblAverageValue = new MaterialSkin.Controls.MaterialLabel();
            this.lblMinValue = new MaterialSkin.Controls.MaterialLabel();
            this.lblMaxValue = new MaterialSkin.Controls.MaterialLabel();
            this.btnBack = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pnlContinuos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContinuos
            // 
            this.pnlContinuos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContinuos.Controls.Add(this.lblCoeficienteVariacao);
            this.pnlContinuos.Controls.Add(this.lblAmplitude);
            this.pnlContinuos.Controls.Add(this.lblDesvioPadrao);
            this.pnlContinuos.Controls.Add(this.lblVariancia);
            this.pnlContinuos.Controls.Add(this.lblMediana);
            this.pnlContinuos.Controls.Add(this.lblModa);
            this.pnlContinuos.Controls.Add(this.lblAverageValue);
            this.pnlContinuos.Controls.Add(this.lblMinValue);
            this.pnlContinuos.Controls.Add(this.lblMaxValue);
            this.pnlContinuos.Location = new System.Drawing.Point(12, 78);
            this.pnlContinuos.Name = "pnlContinuos";
            this.pnlContinuos.Size = new System.Drawing.Size(455, 247);
            this.pnlContinuos.TabIndex = 0;
            // 
            // lblCoeficienteVariacao
            // 
            this.lblCoeficienteVariacao.AutoSize = true;
            this.lblCoeficienteVariacao.Depth = 0;
            this.lblCoeficienteVariacao.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCoeficienteVariacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCoeficienteVariacao.Location = new System.Drawing.Point(23, 221);
            this.lblCoeficienteVariacao.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCoeficienteVariacao.Name = "lblCoeficienteVariacao";
            this.lblCoeficienteVariacao.Size = new System.Drawing.Size(178, 19);
            this.lblCoeficienteVariacao.TabIndex = 8;
            this.lblCoeficienteVariacao.Text = "Coeficiente de Variação: ";
            // 
            // lblAmplitude
            // 
            this.lblAmplitude.AutoSize = true;
            this.lblAmplitude.Depth = 0;
            this.lblAmplitude.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAmplitude.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAmplitude.Location = new System.Drawing.Point(23, 193);
            this.lblAmplitude.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAmplitude.Name = "lblAmplitude";
            this.lblAmplitude.Size = new System.Drawing.Size(85, 19);
            this.lblAmplitude.TabIndex = 7;
            this.lblAmplitude.Text = "Amplitude: ";
            // 
            // lblDesvioPadrao
            // 
            this.lblDesvioPadrao.AutoSize = true;
            this.lblDesvioPadrao.Depth = 0;
            this.lblDesvioPadrao.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDesvioPadrao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDesvioPadrao.Location = new System.Drawing.Point(23, 168);
            this.lblDesvioPadrao.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDesvioPadrao.Name = "lblDesvioPadrao";
            this.lblDesvioPadrao.Size = new System.Drawing.Size(114, 19);
            this.lblDesvioPadrao.TabIndex = 6;
            this.lblDesvioPadrao.Text = "Desvio Padrao: ";
            // 
            // lblVariancia
            // 
            this.lblVariancia.AutoSize = true;
            this.lblVariancia.Depth = 0;
            this.lblVariancia.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblVariancia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblVariancia.Location = new System.Drawing.Point(23, 137);
            this.lblVariancia.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblVariancia.Name = "lblVariancia";
            this.lblVariancia.Size = new System.Drawing.Size(80, 19);
            this.lblVariancia.TabIndex = 5;
            this.lblVariancia.Text = "Variancia: ";
            // 
            // lblMediana
            // 
            this.lblMediana.AutoSize = true;
            this.lblMediana.Depth = 0;
            this.lblMediana.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblMediana.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMediana.Location = new System.Drawing.Point(23, 111);
            this.lblMediana.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMediana.Name = "lblMediana";
            this.lblMediana.Size = new System.Drawing.Size(74, 19);
            this.lblMediana.TabIndex = 4;
            this.lblMediana.Text = "Mediana: ";
            // 
            // lblModa
            // 
            this.lblModa.AutoSize = true;
            this.lblModa.Depth = 0;
            this.lblModa.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblModa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblModa.Location = new System.Drawing.Point(23, 83);
            this.lblModa.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblModa.Name = "lblModa";
            this.lblModa.Size = new System.Drawing.Size(55, 19);
            this.lblModa.TabIndex = 3;
            this.lblModa.Text = "Moda: ";
            // 
            // lblAverageValue
            // 
            this.lblAverageValue.AutoSize = true;
            this.lblAverageValue.Depth = 0;
            this.lblAverageValue.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAverageValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAverageValue.Location = new System.Drawing.Point(23, 56);
            this.lblAverageValue.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAverageValue.Name = "lblAverageValue";
            this.lblAverageValue.Size = new System.Drawing.Size(58, 19);
            this.lblAverageValue.TabIndex = 2;
            this.lblAverageValue.Text = "Media: ";
            // 
            // lblMinValue
            // 
            this.lblMinValue.AutoSize = true;
            this.lblMinValue.Depth = 0;
            this.lblMinValue.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblMinValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMinValue.Location = new System.Drawing.Point(23, 32);
            this.lblMinValue.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMinValue.Name = "lblMinValue";
            this.lblMinValue.Size = new System.Drawing.Size(108, 19);
            this.lblMinValue.TabIndex = 1;
            this.lblMinValue.Text = "Valor Minimo: ";
            // 
            // lblMaxValue
            // 
            this.lblMaxValue.AutoSize = true;
            this.lblMaxValue.Depth = 0;
            this.lblMaxValue.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblMaxValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMaxValue.Location = new System.Drawing.Point(23, 9);
            this.lblMaxValue.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMaxValue.Name = "lblMaxValue";
            this.lblMaxValue.Size = new System.Drawing.Size(111, 19);
            this.lblMaxValue.TabIndex = 0;
            this.lblMaxValue.Text = "Valor Maximo: ";
            // 
            // btnBack
            // 
            this.btnBack.Depth = 0;
            this.btnBack.Location = new System.Drawing.Point(200, 334);
            this.btnBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBack.Name = "btnBack";
            this.btnBack.Primary = true;
            this.btnBack.Size = new System.Drawing.Size(85, 36);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Voltar";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormContinuous
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 382);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlContinuos);
            this.Name = "FormContinuous";
            this.Text = "Dados continuos";
            this.Load += new System.EventHandler(this.FormContinuous_Load);
            this.pnlContinuos.ResumeLayout(false);
            this.pnlContinuos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContinuos;
        private MaterialSkin.Controls.MaterialLabel lblMaxValue;
        private MaterialSkin.Controls.MaterialLabel lblAverageValue;
        private MaterialSkin.Controls.MaterialLabel lblMinValue;
        private MaterialSkin.Controls.MaterialLabel lblModa;
        private MaterialSkin.Controls.MaterialLabel lblMediana;
        private MaterialSkin.Controls.MaterialLabel lblDesvioPadrao;
        private MaterialSkin.Controls.MaterialLabel lblVariancia;
        private MaterialSkin.Controls.MaterialLabel lblCoeficienteVariacao;
        private MaterialSkin.Controls.MaterialLabel lblAmplitude;
        private MaterialSkin.Controls.MaterialRaisedButton btnBack;
    }
}