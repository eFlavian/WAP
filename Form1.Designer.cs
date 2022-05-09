namespace Test_WAP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.reservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Nume_tbl = new System.Windows.Forms.ColumnHeader();
            this.Data_tbl = new System.Windows.Forms.ColumnHeader();
            this.NoPersons_tbl = new System.Windows.Forms.ColumnHeader();
            this.refresh = new System.Windows.Forms.Button();
            this.wselected = new System.Windows.Forms.Button();
            this.Restaurante_txt = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.serializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.serializeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Restaurant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Locatie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumarPersoane = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Creeaza Rezervare";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reservationBindingSource
            // 
            this.reservationBindingSource.DataSource = typeof(Test_WAP.Reservation);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rezervari";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nume_tbl,
            this.Data_tbl,
            this.NoPersons_tbl});
            this.listView1.Location = new System.Drawing.Point(53, 45);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(304, 186);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemActivate += new System.EventHandler(this.listView1_ItemActivate);
            // 
            // Nume_tbl
            // 
            this.Nume_tbl.Text = "Nume";
            this.Nume_tbl.Width = 100;
            // 
            // Data_tbl
            // 
            this.Data_tbl.Text = "Data";
            this.Data_tbl.Width = 100;
            // 
            // NoPersons_tbl
            // 
            this.NoPersons_tbl.Text = "NoPersons";
            this.NoPersons_tbl.Width = 100;
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(303, 237);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(54, 22);
            this.refresh.TabIndex = 13;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // wselected
            // 
            this.wselected.Location = new System.Drawing.Point(53, 237);
            this.wselected.Name = "wselected";
            this.wselected.Size = new System.Drawing.Size(64, 38);
            this.wselected.TabIndex = 14;
            this.wselected.Text = "what is selected";
            this.wselected.UseVisualStyleBackColor = true;
            this.wselected.Click += new System.EventHandler(this.wselected_Click);
            // 
            // Restaurante_txt
            // 
            this.Restaurante_txt.AutoSize = true;
            this.Restaurante_txt.Location = new System.Drawing.Point(363, 27);
            this.Restaurante_txt.Name = "Restaurante_txt";
            this.Restaurante_txt.Size = new System.Drawing.Size(69, 15);
            this.Restaurante_txt.TabIndex = 16;
            this.Restaurante_txt.Text = "Restaurante";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(889, 25);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializeToolStripMenuItem,
            this.deserializeToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(53, 22);
            this.toolStripDropDownButton1.Text = "Binary";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // serializeToolStripMenuItem
            // 
            this.serializeToolStripMenuItem.Name = "serializeToolStripMenuItem";
            this.serializeToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.serializeToolStripMenuItem.Text = "Serialize";
            this.serializeToolStripMenuItem.Click += new System.EventHandler(this.serializeToolStripMenuItem_Click);
            // 
            // deserializeToolStripMenuItem
            // 
            this.deserializeToolStripMenuItem.Name = "deserializeToolStripMenuItem";
            this.deserializeToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.deserializeToolStripMenuItem.Text = "Deserialize";
            this.deserializeToolStripMenuItem.Click += new System.EventHandler(this.deserializeToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializeToolStripMenuItem1,
            this.deserializeToolStripMenuItem1});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(44, 22);
            this.toolStripDropDownButton2.Text = "XML";
            // 
            // serializeToolStripMenuItem1
            // 
            this.serializeToolStripMenuItem1.Name = "serializeToolStripMenuItem1";
            this.serializeToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.serializeToolStripMenuItem1.Text = "Serialize";
            this.serializeToolStripMenuItem1.Click += new System.EventHandler(this.serializeToolStripMenuItem1_Click);
            // 
            // deserializeToolStripMenuItem1
            // 
            this.deserializeToolStripMenuItem1.Name = "deserializeToolStripMenuItem1";
            this.deserializeToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.deserializeToolStripMenuItem1.Text = "Deserialize";
            this.deserializeToolStripMenuItem1.Click += new System.EventHandler(this.deserializeToolStripMenuItem1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Restaurant,
            this.Locatie,
            this.Client,
            this.NumarPersoane});
            this.dataGridView1.Location = new System.Drawing.Point(363, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(466, 186);
            this.dataGridView1.TabIndex = 18;
            // 
            // Restaurant
            // 
            this.Restaurant.HeaderText = "Restaurant";
            this.Restaurant.Name = "Restaurant";
            // 
            // Locatie
            // 
            this.Locatie.HeaderText = "Locatie";
            this.Locatie.Name = "Locatie";
            // 
            // Client
            // 
            this.Client.HeaderText = "Client";
            this.Client.Name = "Client";
            // 
            // NumarPersoane
            // 
            this.NumarPersoane.HeaderText = "NumarPersoane";
            this.NumarPersoane.Name = "NumarPersoane";
            this.NumarPersoane.Width = 130;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(708, 252);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 335);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Restaurante_txt);
            this.Controls.Add(this.wselected);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private BindingSource reservationBindingSource;
        private ListView listView1;
        private ColumnHeader Nume_tbl;
        private ColumnHeader Data_tbl;
        private ColumnHeader NoPersons_tbl;
        private Button refresh;
        private Button wselected;
        private Label Restaurante_txt;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem serializeToolStripMenuItem;
        private ToolStripMenuItem deserializeToolStripMenuItem;
        private ToolStripDropDownButton toolStripDropDownButton2;
        private ToolStripMenuItem serializeToolStripMenuItem1;
        private ToolStripMenuItem deserializeToolStripMenuItem1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Restaurant;
        private DataGridViewTextBoxColumn Locatie;
        private DataGridViewTextBoxColumn Client;
        private DataGridViewTextBoxColumn NumarPersoane;
        private ComboBox comboBox1;
    }
}