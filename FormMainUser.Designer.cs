namespace HoloSouls_PDKR_NSPD
{
    partial class FormMainUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTambahan = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.numMenu = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvMenuCust = new System.Windows.Forms.DataGridView();
            this.btnKembali = new System.Windows.Forms.Button();
            this.refreshTimer1 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCari = new System.Windows.Forms.Button();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.cmbFilterBy = new System.Windows.Forms.ComboBox();
            this.txtMenu = new System.Windows.Forms.TextBox();
            this.btnTambah = new System.Windows.Forms.Button();
            this.dgvPesanan = new System.Windows.Forms.DataGridView();
            this.lblTotalItem = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotalHarga = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBayar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuCust)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesanan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 219);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 281);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Jumlah:";
            // 
            // txtTambahan
            // 
            this.txtTambahan.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtTambahan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTambahan.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTambahan.Location = new System.Drawing.Point(51, 380);
            this.txtTambahan.Margin = new System.Windows.Forms.Padding(4);
            this.txtTambahan.Name = "txtTambahan";
            this.txtTambahan.Size = new System.Drawing.Size(423, 22);
            this.txtTambahan.TabIndex = 9;
            this.txtTambahan.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEdit.Location = new System.Drawing.Point(157, 430);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 28);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHapus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHapus.Location = new System.Drawing.Point(265, 430);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(4);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(100, 28);
            this.btnHapus.TabIndex = 14;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReload.ForeColor = System.Drawing.SystemColors.Window;
            this.btnReload.Location = new System.Drawing.Point(375, 430);
            this.btnReload.Margin = new System.Windows.Forms.Padding(4);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(100, 28);
            this.btnReload.TabIndex = 15;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Location = new System.Drawing.Point(51, 476);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(424, 28);
            this.button5.TabIndex = 16;
            this.button5.Text = "Clear";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(44, 340);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Catatan tambahan\r\n";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // numMenu
            // 
            this.numMenu.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.numMenu.Location = new System.Drawing.Point(51, 300);
            this.numMenu.Margin = new System.Windows.Forms.Padding(4);
            this.numMenu.Name = "numMenu";
            this.numMenu.Size = new System.Drawing.Size(118, 22);
            this.numMenu.TabIndex = 18;
            this.numMenu.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(47, 361);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "*opsional\r\n";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HoloSouls_PDKR_NSPD.Properties.Resources.Pesannn;
            this.pictureBox2.Location = new System.Drawing.Point(-7, -1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1096, 31);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(752, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "MENU";
            // 
            // dgvMenuCust
            // 
            this.dgvMenuCust.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvMenuCust.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMenuCust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenuCust.Location = new System.Drawing.Point(549, 58);
            this.dgvMenuCust.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMenuCust.Name = "dgvMenuCust";
            this.dgvMenuCust.RowHeadersWidth = 57;
            this.dgvMenuCust.Size = new System.Drawing.Size(455, 150);
            this.dgvMenuCust.TabIndex = 23;
            this.dgvMenuCust.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenuCust_CellContentClick);
            // 
            // btnKembali
            // 
            this.btnKembali.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnKembali.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKembali.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnKembali.Location = new System.Drawing.Point(8, 13);
            this.btnKembali.Margin = new System.Windows.Forms.Padding(4);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(108, 28);
            this.btnKembali.TabIndex = 24;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = false;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(193, 34);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "BUAT PESANAN";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.btnCari);
            this.groupBox1.Controls.Add(this.txtHarga);
            this.groupBox1.Controls.Add(this.cmbFilterBy);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(549, 239);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 131);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(12, 83);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(330, 38);
            this.btnCari.TabIndex = 2;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(139, 33);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(203, 25);
            this.txtHarga.TabIndex = 1;
            // 
            // cmbFilterBy
            // 
            this.cmbFilterBy.FormattingEnabled = true;
            this.cmbFilterBy.Items.AddRange(new object[] {
            "Nasi Ayam",
            "Nasi Ikan",
            "Nasi Telur",
            "Nasi Sapi",
            "Nasi Udang"});
            this.cmbFilterBy.Location = new System.Drawing.Point(12, 33);
            this.cmbFilterBy.Name = "cmbFilterBy";
            this.cmbFilterBy.Size = new System.Drawing.Size(121, 26);
            this.cmbFilterBy.TabIndex = 0;
            // 
            // txtMenu
            // 
            this.txtMenu.Location = new System.Drawing.Point(49, 242);
            this.txtMenu.Name = "txtMenu";
            this.txtMenu.Size = new System.Drawing.Size(340, 22);
            this.txtMenu.TabIndex = 27;
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTambah.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTambah.Location = new System.Drawing.Point(49, 430);
            this.btnTambah.Margin = new System.Windows.Forms.Padding(4);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(100, 28);
            this.btnTambah.TabIndex = 28;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // dgvPesanan
            // 
            this.dgvPesanan.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvPesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesanan.Location = new System.Drawing.Point(51, 58);
            this.dgvPesanan.Name = "dgvPesanan";
            this.dgvPesanan.RowHeadersWidth = 57;
            this.dgvPesanan.RowTemplate.Height = 24;
            this.dgvPesanan.Size = new System.Drawing.Size(400, 150);
            this.dgvPesanan.TabIndex = 29;
            // 
            // lblTotalItem
            // 
            this.lblTotalItem.AutoSize = true;
            this.lblTotalItem.Location = new System.Drawing.Point(557, 403);
            this.lblTotalItem.Name = "lblTotalItem";
            this.lblTotalItem.Size = new System.Drawing.Size(14, 16);
            this.lblTotalItem.TabIndex = 30;
            this.lblTotalItem.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(645, 430);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 16);
            this.label8.TabIndex = 31;
            this.label8.Text = "0";
            // 
            // lblTotalHarga
            // 
            this.lblTotalHarga.AutoSize = true;
            this.lblTotalHarga.Location = new System.Drawing.Point(557, 430);
            this.lblTotalHarga.Name = "lblTotalHarga";
            this.lblTotalHarga.Size = new System.Drawing.Size(79, 16);
            this.lblTotalHarga.TabIndex = 33;
            this.lblTotalHarga.Text = "Total Harga";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(59, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 16);
            this.label9.TabIndex = 34;
            this.label9.Text = "Pilih menu di tabel menu";
            // 
            // btnBayar
            // 
            this.btnBayar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBayar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBayar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBayar.Location = new System.Drawing.Point(767, 476);
            this.btnBayar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBayar.Name = "btnBayar";
            this.btnBayar.Size = new System.Drawing.Size(277, 28);
            this.btnBayar.TabIndex = 35;
            this.btnBayar.Text = "Bayar";
            this.btnBayar.UseVisualStyleBackColor = false;
            this.btnBayar.Click += new System.EventHandler(this.btnBayar_Click);
            // 
            // FormMainUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HoloSouls_PDKR_NSPD.Properties.Resources.Frame_41;
            this.ClientSize = new System.Drawing.Size(1083, 524);
            this.Controls.Add(this.btnBayar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblTotalHarga);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblTotalItem);
            this.Controls.Add(this.dgvPesanan);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.txtMenu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.dgvMenuCust);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numMenu);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtTambahan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMainUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMainUser";
            this.Load += new System.EventHandler(this.FormMainUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuCust)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesanan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTambahan;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numMenu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvMenuCust;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.Timer refreshTimer1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.ComboBox cmbFilterBy;
        private System.Windows.Forms.TextBox txtMenu;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.DataGridView dgvPesanan;
        private System.Windows.Forms.Label lblTotalItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotalHarga;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBayar;
    }
}