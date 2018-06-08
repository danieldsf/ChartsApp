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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlSeriesData = new System.Windows.Forms.Panel();
            this.lblCoeficienteVariacao = new MaterialSkin.Controls.MaterialLabel();
            this.lblDesvioPadrao = new MaterialSkin.Controls.MaterialLabel();
            this.lblvariancia = new MaterialSkin.Controls.MaterialLabel();
            this.lblModa = new MaterialSkin.Controls.MaterialLabel();
            this.lblMediana = new MaterialSkin.Controls.MaterialLabel();
            this.lblMedia = new MaterialSkin.Controls.MaterialLabel();
            this.btnBack = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tbcSeries = new System.Windows.Forms.TabControl();
            this.tbpDados = new System.Windows.Forms.TabPage();
            this.tbpFrequencia = new System.Windows.Forms.TabPage();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.tbpHistograma = new System.Windows.Forms.TabPage();
            this.chartSeries = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tbpComparacao = new System.Windows.Forms.TabPage();
            this.lblMediaTitle = new MaterialSkin.Controls.MaterialLabel();
            this.lblMedianaTitle = new MaterialSkin.Controls.MaterialLabel();
            this.lblMediaComparation = new MaterialSkin.Controls.MaterialLabel();
            this.lblMedianaComparation = new MaterialSkin.Controls.MaterialLabel();
            this.pnlSeriesData.SuspendLayout();
            this.tbcSeries.SuspendLayout();
            this.tbpDados.SuspendLayout();
            this.tbpFrequencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.tbpHistograma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSeries)).BeginInit();
            this.tbpComparacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSeriesData
            // 
            this.pnlSeriesData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSeriesData.Controls.Add(this.lblCoeficienteVariacao);
            this.pnlSeriesData.Controls.Add(this.lblDesvioPadrao);
            this.pnlSeriesData.Controls.Add(this.lblvariancia);
            this.pnlSeriesData.Controls.Add(this.lblModa);
            this.pnlSeriesData.Controls.Add(this.lblMediana);
            this.pnlSeriesData.Controls.Add(this.lblMedia);
            this.pnlSeriesData.Location = new System.Drawing.Point(6, 6);
            this.pnlSeriesData.Name = "pnlSeriesData";
            this.pnlSeriesData.Size = new System.Drawing.Size(667, 309);
            this.pnlSeriesData.TabIndex = 1;
            // 
            // lblCoeficienteVariacao
            // 
            this.lblCoeficienteVariacao.AutoSize = true;
            this.lblCoeficienteVariacao.Depth = 0;
            this.lblCoeficienteVariacao.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCoeficienteVariacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCoeficienteVariacao.Location = new System.Drawing.Point(7, 166);
            this.lblCoeficienteVariacao.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCoeficienteVariacao.Name = "lblCoeficienteVariacao";
            this.lblCoeficienteVariacao.Size = new System.Drawing.Size(158, 19);
            this.lblCoeficienteVariacao.TabIndex = 5;
            this.lblCoeficienteVariacao.Text = "Coeficiente Variacao: ";
            // 
            // lblDesvioPadrao
            // 
            this.lblDesvioPadrao.AutoSize = true;
            this.lblDesvioPadrao.Depth = 0;
            this.lblDesvioPadrao.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDesvioPadrao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDesvioPadrao.Location = new System.Drawing.Point(7, 134);
            this.lblDesvioPadrao.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDesvioPadrao.Name = "lblDesvioPadrao";
            this.lblDesvioPadrao.Size = new System.Drawing.Size(113, 19);
            this.lblDesvioPadrao.TabIndex = 4;
            this.lblDesvioPadrao.Text = "Desvio padrao: ";
            // 
            // lblvariancia
            // 
            this.lblvariancia.AutoSize = true;
            this.lblvariancia.Depth = 0;
            this.lblvariancia.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblvariancia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblvariancia.Location = new System.Drawing.Point(7, 104);
            this.lblvariancia.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblvariancia.Name = "lblvariancia";
            this.lblvariancia.Size = new System.Drawing.Size(80, 19);
            this.lblvariancia.TabIndex = 3;
            this.lblvariancia.Text = "Variancia: ";
            // 
            // lblModa
            // 
            this.lblModa.AutoSize = true;
            this.lblModa.Depth = 0;
            this.lblModa.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblModa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblModa.Location = new System.Drawing.Point(7, 44);
            this.lblModa.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblModa.Name = "lblModa";
            this.lblModa.Size = new System.Drawing.Size(55, 19);
            this.lblModa.TabIndex = 2;
            this.lblModa.Text = "Moda: ";
            // 
            // lblMediana
            // 
            this.lblMediana.AutoSize = true;
            this.lblMediana.Depth = 0;
            this.lblMediana.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblMediana.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMediana.Location = new System.Drawing.Point(7, 73);
            this.lblMediana.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMediana.Name = "lblMediana";
            this.lblMediana.Size = new System.Drawing.Size(74, 19);
            this.lblMediana.TabIndex = 1;
            this.lblMediana.Text = "Mediana: ";
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Depth = 0;
            this.lblMedia.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblMedia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMedia.Location = new System.Drawing.Point(7, 17);
            this.lblMedia.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(58, 19);
            this.lblMedia.TabIndex = 0;
            this.lblMedia.Text = "Media: ";
            // 
            // btnBack
            // 
            this.btnBack.Depth = 0;
            this.btnBack.Location = new System.Drawing.Point(337, 430);
            this.btnBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBack.Name = "btnBack";
            this.btnBack.Primary = true;
            this.btnBack.Size = new System.Drawing.Size(89, 44);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Voltar";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tbcSeries
            // 
            this.tbcSeries.Controls.Add(this.tbpDados);
            this.tbcSeries.Controls.Add(this.tbpFrequencia);
            this.tbcSeries.Controls.Add(this.tbpHistograma);
            this.tbcSeries.Controls.Add(this.tbpComparacao);
            this.tbcSeries.Location = new System.Drawing.Point(12, 77);
            this.tbcSeries.Name = "tbcSeries";
            this.tbcSeries.SelectedIndex = 0;
            this.tbcSeries.Size = new System.Drawing.Size(687, 347);
            this.tbcSeries.TabIndex = 7;
            // 
            // tbpDados
            // 
            this.tbpDados.Controls.Add(this.pnlSeriesData);
            this.tbpDados.Location = new System.Drawing.Point(4, 22);
            this.tbpDados.Name = "tbpDados";
            this.tbpDados.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDados.Size = new System.Drawing.Size(679, 321);
            this.tbpDados.TabIndex = 0;
            this.tbpDados.Text = "Dados";
            this.tbpDados.UseVisualStyleBackColor = true;
            // 
            // tbpFrequencia
            // 
            this.tbpFrequencia.Controls.Add(this.dgv);
            this.tbpFrequencia.Location = new System.Drawing.Point(4, 22);
            this.tbpFrequencia.Name = "tbpFrequencia";
            this.tbpFrequencia.Padding = new System.Windows.Forms.Padding(3);
            this.tbpFrequencia.Size = new System.Drawing.Size(679, 321);
            this.tbpFrequencia.TabIndex = 1;
            this.tbpFrequencia.Text = "Tabela de Frequencia";
            this.tbpFrequencia.UseVisualStyleBackColor = true;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(6, 6);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(667, 309);
            this.dgv.TabIndex = 1;
            // 
            // tbpHistograma
            // 
            this.tbpHistograma.Controls.Add(this.chartSeries);
            this.tbpHistograma.Location = new System.Drawing.Point(4, 22);
            this.tbpHistograma.Name = "tbpHistograma";
            this.tbpHistograma.Size = new System.Drawing.Size(679, 321);
            this.tbpHistograma.TabIndex = 2;
            this.tbpHistograma.Text = "Histograma";
            this.tbpHistograma.UseVisualStyleBackColor = true;
            // 
            // chartSeries
            // 
            this.chartSeries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartSeries.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartSeries.Legends.Add(legend1);
            this.chartSeries.Location = new System.Drawing.Point(6, 3);
            this.chartSeries.Name = "chartSeries";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartSeries.Series.Add(series1);
            this.chartSeries.Size = new System.Drawing.Size(670, 315);
            this.chartSeries.TabIndex = 1;
            this.chartSeries.Text = "chartSeries";
            // 
            // tbpComparacao
            // 
            this.tbpComparacao.Controls.Add(this.lblMedianaComparation);
            this.tbpComparacao.Controls.Add(this.lblMediaComparation);
            this.tbpComparacao.Controls.Add(this.lblMedianaTitle);
            this.tbpComparacao.Controls.Add(this.lblMediaTitle);
            this.tbpComparacao.Location = new System.Drawing.Point(4, 22);
            this.tbpComparacao.Name = "tbpComparacao";
            this.tbpComparacao.Size = new System.Drawing.Size(679, 321);
            this.tbpComparacao.TabIndex = 3;
            this.tbpComparacao.Text = "Comparacao";
            this.tbpComparacao.UseVisualStyleBackColor = true;
            // 
            // lblMediaTitle
            // 
            this.lblMediaTitle.AutoSize = true;
            this.lblMediaTitle.Depth = 0;
            this.lblMediaTitle.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblMediaTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMediaTitle.Location = new System.Drawing.Point(29, 40);
            this.lblMediaTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMediaTitle.Name = "lblMediaTitle";
            this.lblMediaTitle.Size = new System.Drawing.Size(326, 19);
            this.lblMediaTitle.TabIndex = 0;
            this.lblMediaTitle.Text = "Comparacao entre medias (Continuos x Series)";
            // 
            // lblMedianaTitle
            // 
            this.lblMedianaTitle.AutoSize = true;
            this.lblMedianaTitle.Depth = 0;
            this.lblMedianaTitle.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblMedianaTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMedianaTitle.Location = new System.Drawing.Point(29, 161);
            this.lblMedianaTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMedianaTitle.Name = "lblMedianaTitle";
            this.lblMedianaTitle.Size = new System.Drawing.Size(342, 19);
            this.lblMedianaTitle.TabIndex = 1;
            this.lblMedianaTitle.Text = "Comparacao entre medianas (Continuos x Series)";
            // 
            // lblMediaComparation
            // 
            this.lblMediaComparation.AutoSize = true;
            this.lblMediaComparation.Depth = 0;
            this.lblMediaComparation.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblMediaComparation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMediaComparation.Location = new System.Drawing.Point(283, 88);
            this.lblMediaComparation.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMediaComparation.Name = "lblMediaComparation";
            this.lblMediaComparation.Size = new System.Drawing.Size(108, 19);
            this.lblMediaComparation.TabIndex = 2;
            this.lblMediaComparation.Text = "materialLabel3";
            // 
            // lblMedianaComparation
            // 
            this.lblMedianaComparation.AutoSize = true;
            this.lblMedianaComparation.Depth = 0;
            this.lblMedianaComparation.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblMedianaComparation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMedianaComparation.Location = new System.Drawing.Point(283, 204);
            this.lblMedianaComparation.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMedianaComparation.Name = "lblMedianaComparation";
            this.lblMedianaComparation.Size = new System.Drawing.Size(108, 19);
            this.lblMedianaComparation.TabIndex = 3;
            this.lblMedianaComparation.Text = "materialLabel4";
            // 
            // FormSeries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 486);
            this.Controls.Add(this.tbcSeries);
            this.Controls.Add(this.btnBack);
            this.Name = "FormSeries";
            this.Text = "Dados por frequencia";
            this.Load += new System.EventHandler(this.FormSeries_Load);
            this.pnlSeriesData.ResumeLayout(false);
            this.pnlSeriesData.PerformLayout();
            this.tbcSeries.ResumeLayout(false);
            this.tbpDados.ResumeLayout(false);
            this.tbpFrequencia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.tbpHistograma.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartSeries)).EndInit();
            this.tbpComparacao.ResumeLayout(false);
            this.tbpComparacao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlSeriesData;
        private MaterialSkin.Controls.MaterialLabel lblModa;
        private MaterialSkin.Controls.MaterialLabel lblMediana;
        private MaterialSkin.Controls.MaterialLabel lblMedia;
        private MaterialSkin.Controls.MaterialLabel lblCoeficienteVariacao;
        private MaterialSkin.Controls.MaterialLabel lblDesvioPadrao;
        private MaterialSkin.Controls.MaterialLabel lblvariancia;
        private MaterialSkin.Controls.MaterialRaisedButton btnBack;
        private System.Windows.Forms.TabControl tbcSeries;
        private System.Windows.Forms.TabPage tbpDados;
        private System.Windows.Forms.TabPage tbpFrequencia;
        private System.Windows.Forms.TabPage tbpHistograma;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSeries;
        private System.Windows.Forms.TabPage tbpComparacao;
        private MaterialSkin.Controls.MaterialLabel lblMedianaComparation;
        private MaterialSkin.Controls.MaterialLabel lblMediaComparation;
        private MaterialSkin.Controls.MaterialLabel lblMedianaTitle;
        private MaterialSkin.Controls.MaterialLabel lblMediaTitle;
    }
}