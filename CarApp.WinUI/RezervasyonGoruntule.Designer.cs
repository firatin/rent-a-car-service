namespace CarApp.WinUI
{
    partial class RezervasyonGoruntule
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.müşteriyeGöreSıralaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plakayaGöreSıralaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniRezervasyonaGöreSıralaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eskiRezervasyonaGöreSıralaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniRezervasyonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblID = new System.Windows.Forms.Label();
            this.txtTaksit = new System.Windows.Forms.TextBox();
            this.cbArac = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbSofor = new System.Windows.Forms.ComboBox();
            this.cbSube = new System.Windows.Forms.ComboBox();
            this.nmSYakit = new System.Windows.Forms.NumericUpDown();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.dtpTTarih = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.cbOdeme = new System.Windows.Forms.ComboBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSYakit)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(900, 353);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriyeGöreSıralaToolStripMenuItem,
            this.plakayaGöreSıralaToolStripMenuItem,
            this.yeniRezervasyonaGöreSıralaToolStripMenuItem,
            this.eskiRezervasyonaGöreSıralaToolStripMenuItem,
            this.yeniRezervasyonToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(209, 114);
            // 
            // müşteriyeGöreSıralaToolStripMenuItem
            // 
            this.müşteriyeGöreSıralaToolStripMenuItem.Name = "müşteriyeGöreSıralaToolStripMenuItem";
            this.müşteriyeGöreSıralaToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.müşteriyeGöreSıralaToolStripMenuItem.Text = "Müşteriye Göre Sırala";
            this.müşteriyeGöreSıralaToolStripMenuItem.Click += new System.EventHandler(this.müşteriyeGöreSıralaToolStripMenuItem_Click);
            // 
            // plakayaGöreSıralaToolStripMenuItem
            // 
            this.plakayaGöreSıralaToolStripMenuItem.Name = "plakayaGöreSıralaToolStripMenuItem";
            this.plakayaGöreSıralaToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.plakayaGöreSıralaToolStripMenuItem.Text = "Plakaya Göre Sırala";
            this.plakayaGöreSıralaToolStripMenuItem.Click += new System.EventHandler(this.plakayaGöreSıralaToolStripMenuItem_Click);
            // 
            // yeniRezervasyonaGöreSıralaToolStripMenuItem
            // 
            this.yeniRezervasyonaGöreSıralaToolStripMenuItem.Name = "yeniRezervasyonaGöreSıralaToolStripMenuItem";
            this.yeniRezervasyonaGöreSıralaToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.yeniRezervasyonaGöreSıralaToolStripMenuItem.Text = "TeslimTarihine Göre sırala";
            this.yeniRezervasyonaGöreSıralaToolStripMenuItem.Click += new System.EventHandler(this.yeniRezervasyonaGöreSıralaToolStripMenuItem_Click);
            // 
            // eskiRezervasyonaGöreSıralaToolStripMenuItem
            // 
            this.eskiRezervasyonaGöreSıralaToolStripMenuItem.Name = "eskiRezervasyonaGöreSıralaToolStripMenuItem";
            this.eskiRezervasyonaGöreSıralaToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.eskiRezervasyonaGöreSıralaToolStripMenuItem.Text = "AlışTarihineGöre Sırala";
            this.eskiRezervasyonaGöreSıralaToolStripMenuItem.Click += new System.EventHandler(this.eskiRezervasyonaGöreSıralaToolStripMenuItem_Click);
            // 
            // yeniRezervasyonToolStripMenuItem
            // 
            this.yeniRezervasyonToolStripMenuItem.Name = "yeniRezervasyonToolStripMenuItem";
            this.yeniRezervasyonToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.yeniRezervasyonToolStripMenuItem.Text = "Yeni Rezervasyon";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblID.Location = new System.Drawing.Point(1, 356);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(20, 13);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "ID";
            // 
            // txtTaksit
            // 
            this.txtTaksit.Location = new System.Drawing.Point(613, 372);
            this.txtTaksit.Name = "txtTaksit";
            this.txtTaksit.Size = new System.Drawing.Size(33, 20);
            this.txtTaksit.TabIndex = 2;
            // 
            // cbArac
            // 
            this.cbArac.FormattingEnabled = true;
            this.cbArac.Location = new System.Drawing.Point(4, 372);
            this.cbArac.Name = "cbArac";
            this.cbArac.Size = new System.Drawing.Size(108, 21);
            this.cbArac.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(128, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Şöför";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(255, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şube";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(483, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ödeme";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(610, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Taksit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(648, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Yakıt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(699, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Teslim Tarihi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(80, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Araç";
            // 
            // cbSofor
            // 
            this.cbSofor.FormattingEnabled = true;
            this.cbSofor.Location = new System.Drawing.Point(131, 372);
            this.cbSofor.Name = "cbSofor";
            this.cbSofor.Size = new System.Drawing.Size(108, 21);
            this.cbSofor.TabIndex = 4;
            this.cbSofor.Text = "Seçiniz";
            // 
            // cbSube
            // 
            this.cbSube.FormattingEnabled = true;
            this.cbSube.Location = new System.Drawing.Point(258, 372);
            this.cbSube.Name = "cbSube";
            this.cbSube.Size = new System.Drawing.Size(108, 21);
            this.cbSube.TabIndex = 4;
            // 
            // nmSYakit
            // 
            this.nmSYakit.Location = new System.Drawing.Point(651, 372);
            this.nmSYakit.Name = "nmSYakit";
            this.nmSYakit.Size = new System.Drawing.Size(45, 20);
            this.nmSYakit.TabIndex = 5;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(702, 397);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(106, 23);
            this.btnGuncelle.TabIndex = 6;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // dtpTTarih
            // 
            this.dtpTTarih.Location = new System.Drawing.Point(702, 372);
            this.dtpTTarih.Name = "dtpTTarih";
            this.dtpTTarih.Size = new System.Drawing.Size(109, 20);
            this.dtpTTarih.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(369, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Model";
            // 
            // cbOdeme
            // 
            this.cbOdeme.FormattingEnabled = true;
            this.cbOdeme.Items.AddRange(new object[] {
            "Pesin",
            "KrediKartı",
            "Peşin",
            "KrediKartı"});
            this.cbOdeme.Location = new System.Drawing.Point(486, 372);
            this.cbOdeme.Name = "cbOdeme";
            this.cbOdeme.Size = new System.Drawing.Size(108, 21);
            this.cbOdeme.TabIndex = 4;
            this.cbOdeme.Text = "ÖdemeTipiSeçin";
            // 
            // txtModel
            // 
            this.txtModel.Enabled = false;
            this.txtModel.Location = new System.Drawing.Point(372, 372);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 8;
            // 
            // RezervasyonGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CarApp.WinUI.Properties.Resources.gray_art_design_4004;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 442);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.dtpTTarih);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.nmSYakit);
            this.Controls.Add(this.cbSube);
            this.Controls.Add(this.cbSofor);
            this.Controls.Add(this.cbArac);
            this.Controls.Add(this.cbOdeme);
            this.Controls.Add(this.txtTaksit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RezervasyonGoruntule";
            this.Text = "KayitGoruntuleme";
            this.Load += new System.EventHandler(this.KayitGoruntuleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmSYakit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem müşteriyeGöreSıralaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniRezervasyonToolStripMenuItem;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtTaksit;
        private System.Windows.Forms.ComboBox cbArac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbSofor;
        private System.Windows.Forms.ComboBox cbSube;
        private System.Windows.Forms.NumericUpDown nmSYakit;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.DateTimePicker dtpTTarih;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbOdeme;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.ToolStripMenuItem plakayaGöreSıralaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniRezervasyonaGöreSıralaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eskiRezervasyonaGöreSıralaToolStripMenuItem;
    }
}