namespace PROJECT___WAP
{
    partial class Chart
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
            this.pieChartControl1 = new PROJECT___WAP.PieChartControl();
            this.SuspendLayout();
            // 
            // pieChartControl1
            // 
            this.pieChartControl1.Location = new System.Drawing.Point(33, 39);
            this.pieChartControl1.Name = "pieChartControl1";
            this.pieChartControl1.Size = new System.Drawing.Size(294, 279);
            this.pieChartControl1.TabIndex = 0;
            this.pieChartControl1.Text = "pieChartControl1";
            this.pieChartControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.pieChartControl1_Paint);
            // 
            // Chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 366);
            this.Controls.Add(this.pieChartControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Chart";
            this.Text = "Chart";
            this.Load += new System.EventHandler(this.Chart_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private PieChartControl pieChartControl1;
    }
}