namespace ChartsApp
{
    partial class FormSeries
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
            this.btnGoBack = new System.Windows.Forms.Button();
            this.pnlSeriesData = new System.Windows.Forms.Panel();
            this.btnHistograma = new System.Windows.Forms.Button();
            this.btnTable = new System.Windows.Forms.Button();
            this.lblMedia = new System.Windows.Forms.Label();
            this.lblMediana = new System.Windows.Forms.Label();
            this.lblModa = new System.Windows.Forms.Label();
            this.lblvariancia = new System.Windows.Forms.Label();
            this.lblDesvioPadrao = new System.Windows.Forms.Label();
            this.lblCoeficienteVariacao = new System.Windows.Forms.Label();
            this.pnlSeriesData.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGoBack
            // 
            this.btnGoBack.Location = new System.Drawing.Point(12, 341);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(88, 23);
            this.btnGoBack.TabIndex = 0;
            this.btnGoBack.Text = "Voltar";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // pnlSeriesData
            // 
            this.pnlSeriesData.Controls.Add(this.lblCoeficienteVariacao);
            this.pnlSeriesData.Controls.Add(this.lblDesvioPadrao);
            this.pnlSeriesData.Controls.Add(this.lblvariancia);
            this.pnlSeriesData.Controls.Add(this.lblModa);
            this.pnlSeriesData.Controls.Add(this.lblMediana);
            this.pnlSeriesData.Controls.Add(this.lblMedia);
            this.pnlSeriesData.Location = new System.Drawing.Point(12, 80);
            this.pnlSeriesData.Name = "pnlSeriesData";
            this.pnlSeriesData.Size = new System.Drawing.Size(401, 255);
            this.pnlSeriesData.TabIndex = 1;
            // 
            // btnHistograma
            // 
            this.btnHistograma.Location = new System.Drawing.Point(143, 341);
            this.btnHistograma.Name = "btnHistograma";
            this.btnHistograma.Size = new System.Drawing.Size(96, 23);
            this.btnHistograma.TabIndex = 2;
            this.btnHistograma.Text = "Ver Histograma";
            this.btnHistograma.UseVisualStyleBackColor = true;
            this.btnHistograma.Click += new System.EventHandler(this.btnHistograma_Click);
            // 
            // btnTable
            // 
            this.btnTable.Location = new System.Drawing.Point(255, 341);
            this.btnTable.Name = "btnTable";
            this.btnTable.Size = new System.Drawing.Size(158, 23);
            this.btnTable.TabIndex = 3;
            this.btnTable.Text = "Ver distribuicao de frquencia";
            this.btnTable.UseVisualStyleBackColor = true;
            this.btnTable.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Location = new System.Drawing.Point(7, 17);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(42, 13);
            this.lblMedia.TabIndex = 0;
            this.lblMedia.Text = "Media: ";
            // 
            // lblMediana
            // 
            this.lblMediana.AutoSize = true;
            this.lblMediana.Location = new System.Drawing.Point(7, 47);
            this.lblMediana.Name = "lblMediana";
            this.lblMediana.Size = new System.Drawing.Size(54, 13);
            this.lblMediana.TabIndex = 1;
            this.lblMediana.Text = "Mediana: ";
            // 
            // lblModa
            // 
            this.lblModa.AutoSize = true;
            this.lblModa.Location = new System.Drawing.Point(7, 77);
            this.lblModa.Name = "lblModa";
            this.lblModa.Size = new System.Drawing.Size(40, 13);
            this.lblModa.TabIndex = 2;
            this.lblModa.Text = "Moda: ";
            // 
            // lblvariancia
            // 
            this.lblvariancia.AutoSize = true;
            this.lblvariancia.Location = new System.Drawing.Point(7, 104);
            this.lblvariancia.Name = "lblvariancia";
            this.lblvariancia.Size = new System.Drawing.Size(57, 13);
            this.lblvariancia.TabIndex = 3;
            this.lblvariancia.Text = "Variancia: ";
            // 
            // lblDesvioPadrao
            // 
            this.lblDesvioPadrao.AutoSize = true;
            this.lblDesvioPadrao.Location = new System.Drawing.Point(7, 134);
            this.lblDesvioPadrao.Name = "lblDesvioPadrao";
            this.lblDesvioPadrao.Size = new System.Drawing.Size(82, 13);
            this.lblDesvioPadrao.TabIndex = 4;
            this.lblDesvioPadrao.Text = "Desvio padrao: ";
            // 
            // lblCoeficienteVariacao
            // 
            this.lblCoeficienteVariacao.AutoSize = true;
            this.lblCoeficienteVariacao.Location = new System.Drawing.Point(7, 166);
            this.lblCoeficienteVariacao.Name = "lblCoeficienteVariacao";
            this.lblCoeficienteVariacao.Size = new System.Drawing.Size(111, 13);
            this.lblCoeficienteVariacao.TabIndex = 5;
            this.lblCoeficienteVariacao.Text = "Coeficiente Variacao: ";
            // 
            // FormSeries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 376);
            this.Controls.Add(this.btnTable);
            this.Controls.Add(this.btnHistograma);
            this.Controls.Add(this.pnlSeriesData);
            this.Controls.Add(this.btnGoBack);
            this.Name = "FormSeries";
            this.Text = "Dados por frequencia";
            this.Load += new System.EventHandler(this.FormSeries_Load);
            this.pnlSeriesData.ResumeLayout(false);
            this.pnlSeriesData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Panel pnlSeriesData;
        private System.Windows.Forms.Button btnHistograma;
        private System.Windows.Forms.Button btnTable;
        private System.Windows.Forms.Label lblModa;
        private System.Windows.Forms.Label lblMediana;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label lblCoeficienteVariacao;
        private System.Windows.Forms.Label lblDesvioPadrao;
        private System.Windows.Forms.Label lblvariancia;
    }
}