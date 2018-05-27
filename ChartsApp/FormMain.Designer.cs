namespace ChartsApp
{
    partial class Main
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
            this.btnContinuous = new System.Windows.Forms.Button();
            this.btnSeries = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnContinuous
            // 
            this.btnContinuous.Location = new System.Drawing.Point(25, 149);
            this.btnContinuous.Name = "btnContinuous";
            this.btnContinuous.Size = new System.Drawing.Size(99, 23);
            this.btnContinuous.TabIndex = 0;
            this.btnContinuous.Text = "Dados continuos";
            this.btnContinuous.UseVisualStyleBackColor = true;
            this.btnContinuous.Click += new System.EventHandler(this.btnContinuous_Click);
            // 
            // btnSeries
            // 
            this.btnSeries.Location = new System.Drawing.Point(130, 149);
            this.btnSeries.Name = "btnSeries";
            this.btnSeries.Size = new System.Drawing.Size(123, 23);
            this.btnSeries.TabIndex = 1;
            this.btnSeries.Text = "Dados por frequencia";
            this.btnSeries.UseVisualStyleBackColor = true;
            this.btnSeries.Click += new System.EventHandler(this.btnSeries_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnSeries);
            this.Controls.Add(this.btnContinuous);
            this.Name = "Main";
            this.Text = "Dados populacionais Brasil 2010";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnContinuous;
        private System.Windows.Forms.Button btnSeries;
    }
}

