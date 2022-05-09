namespace Test_WAP
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.nume_txt = new System.Windows.Forms.TextBox();
            this.No_Persons_txt = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ADAUGA = new System.Windows.Forms.Button();
            this.nume_label = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.nopers = new System.Windows.Forms.Label();
            this.reservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // nume_txt
            // 
            this.nume_txt.Location = new System.Drawing.Point(115, 32);
            this.nume_txt.Name = "nume_txt";
            this.nume_txt.Size = new System.Drawing.Size(100, 23);
            this.nume_txt.TabIndex = 0;
            // 
            // No_Persons_txt
            // 
            this.No_Persons_txt.Location = new System.Drawing.Point(115, 137);
            this.No_Persons_txt.Name = "No_Persons_txt";
            this.No_Persons_txt.Size = new System.Drawing.Size(100, 23);
            this.No_Persons_txt.TabIndex = 1;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(115, 81);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker.TabIndex = 2;
            // 
            // ADAUGA
            // 
            this.ADAUGA.Location = new System.Drawing.Point(127, 195);
            this.ADAUGA.Name = "ADAUGA";
            this.ADAUGA.Size = new System.Drawing.Size(75, 23);
            this.ADAUGA.TabIndex = 3;
            this.ADAUGA.Text = "ADAUGA";
            this.ADAUGA.UseVisualStyleBackColor = true;
            this.ADAUGA.Click += new System.EventHandler(this.button1_Click);
            // 
            // nume_label
            // 
            this.nume_label.AutoSize = true;
            this.nume_label.Location = new System.Drawing.Point(69, 35);
            this.nume_label.Name = "nume_label";
            this.nume_label.Size = new System.Drawing.Size(40, 15);
            this.nume_label.TabIndex = 4;
            this.nume_label.Text = "Nume";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(78, 87);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(31, 15);
            this.Date.TabIndex = 5;
            this.Date.Text = "Data";
            // 
            // nopers
            // 
            this.nopers.AutoSize = true;
            this.nopers.Location = new System.Drawing.Point(38, 140);
            this.nopers.Name = "nopers";
            this.nopers.Size = new System.Drawing.Size(71, 15);
            this.nopers.TabIndex = 6;
            this.nopers.Text = "Nr Persoane";
            // 
            // reservationBindingSource
            // 
            this.reservationBindingSource.DataSource = typeof(Test_WAP.Reservation);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 240);
            this.Controls.Add(this.nopers);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.nume_label);
            this.Controls.Add(this.ADAUGA);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.No_Persons_txt);
            this.Controls.Add(this.nume_txt);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox nume_txt;
        private TextBox No_Persons_txt;
        private DateTimePicker dateTimePicker;
        private Button ADAUGA;
        private Label nume_label;
        private Label Date;
        private Label nopers;
        private BindingSource reservationBindingSource;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
    }
}