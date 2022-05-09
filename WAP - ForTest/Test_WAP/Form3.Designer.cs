namespace Test_WAP
{
    partial class Form3
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
            this.nopers = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.nume_label = new System.Windows.Forms.Label();
            this.EDITEAZA = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.No_Persons_txt = new System.Windows.Forms.TextBox();
            this.nume_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nopers
            // 
            this.nopers.AutoSize = true;
            this.nopers.Location = new System.Drawing.Point(29, 147);
            this.nopers.Name = "nopers";
            this.nopers.Size = new System.Drawing.Size(71, 15);
            this.nopers.TabIndex = 13;
            this.nopers.Text = "Nr Persoane";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(69, 94);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(31, 15);
            this.Date.TabIndex = 12;
            this.Date.Text = "Data";
            // 
            // nume_label
            // 
            this.nume_label.AutoSize = true;
            this.nume_label.Location = new System.Drawing.Point(60, 42);
            this.nume_label.Name = "nume_label";
            this.nume_label.Size = new System.Drawing.Size(40, 15);
            this.nume_label.TabIndex = 11;
            this.nume_label.Text = "Nume";
            // 
            // EDITEAZA
            // 
            this.EDITEAZA.Location = new System.Drawing.Point(118, 202);
            this.EDITEAZA.Name = "EDITEAZA";
            this.EDITEAZA.Size = new System.Drawing.Size(75, 23);
            this.EDITEAZA.TabIndex = 10;
            this.EDITEAZA.Text = "EDITEAZA";
            this.EDITEAZA.UseVisualStyleBackColor = true;
            this.EDITEAZA.Click += new System.EventHandler(this.EDITEAZA_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(106, 88);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker.TabIndex = 9;
            // 
            // No_Persons_txt
            // 
            this.No_Persons_txt.Location = new System.Drawing.Point(106, 144);
            this.No_Persons_txt.Name = "No_Persons_txt";
            this.No_Persons_txt.Size = new System.Drawing.Size(100, 23);
            this.No_Persons_txt.TabIndex = 8;
            // 
            // nume_txt
            // 
            this.nume_txt.Location = new System.Drawing.Point(106, 39);
            this.nume_txt.Name = "nume_txt";
            this.nume_txt.Size = new System.Drawing.Size(100, 23);
            this.nume_txt.TabIndex = 7;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 257);
            this.Controls.Add(this.nopers);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.nume_label);
            this.Controls.Add(this.EDITEAZA);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.No_Persons_txt);
            this.Controls.Add(this.nume_txt);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label nopers;
        private Label Date;
        private Label nume_label;
        private Button EDITEAZA;
        private DateTimePicker dateTimePicker;
        private TextBox No_Persons_txt;
        private TextBox nume_txt;
    }
}