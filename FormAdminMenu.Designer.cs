namespace HoloSouls_PDKR_NSPD
{
    partial class FormAdminMenu
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
            this.label2NamaMenu = new System.Windows.Forms.Label();
            this.label1Harga = new System.Windows.Forms.Label();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1Menu = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtHargaAdm = new System.Windows.Forms.TextBox();
            this.cmbFilterBy = new System.Windows.Forms.ComboBox();
            this.btnCariAdm = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblPageInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2NamaMenu
            // 
            this.label2NamaMenu.AutoSize = true;
            this.label2NamaMenu.Font = new System.Drawing.Font("Myanmar Text", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2NamaMenu.Location = new System.Drawing.Point(21, 21);
            this.label2NamaMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2NamaMenu.Name = "label2NamaMenu";
            this.label2NamaMenu.Size = new System.Drawing.Size(134, 34);
            this.label2NamaMenu.TabIndex = 2;
            this.label2NamaMenu.Text = "Nama Menu :";
            this.label2NamaMenu.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1Harga
            // 
            this.label1Harga.AutoSize = true;
            this.label1Harga.Font = new System.Drawing.Font("Myanmar Text", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Harga.Location = new System.Drawing.Point(23, 94);
            this.label1Harga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1Harga.Name = "label1Harga";
            this.label1Harga.Size = new System.Drawing.Size(80, 34);
            this.label1Harga.TabIndex = 3;
            this.label1Harga.Text = "Harga :\r\n";
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.RosyBrown;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1081, 42);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label1Menu
            // 
            this.label1Menu.AutoSize = true;
            this.label1Menu.BackColor = System.Drawing.Color.Maroon;
            this.label1Menu.Font = new System.Drawing.Font("Myanmar Text", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Menu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1Menu.Location = new System.Drawing.Point(145, 53);
            this.label1Menu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1Menu.Name = "label1Menu";
            this.label1Menu.Size = new System.Drawing.Size(143, 34);
            this.label1Menu.TabIndex = 12;
            this.label1Menu.Text = "Tambah Menu\r\n";
            this.label1Menu.Click += new System.EventHandler(this.label1Menu_Click);
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.IndianRed;
            this.btnReload.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReload.Location = new System.Drawing.Point(335, 418);
            this.btnReload.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(100, 28);
            this.btnReload.TabIndex = 13;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.IndianRed;
            this.btnClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(13, 454);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(421, 38);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.IndianRed;
            this.btnCreate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCreate.Location = new System.Drawing.Point(13, 418);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(100, 28);
            this.btnCreate.TabIndex = 17;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Location = new System.Drawing.Point(227, 418);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.IndianRed;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.Location = new System.Drawing.Point(119, 418);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 28);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.RosyBrown;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(12, 7);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(151, 28);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "Kembali";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(27, 57);
            this.txtNama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(372, 32);
            this.txtNama.TabIndex = 23;
            this.txtNama.TextChanged += new System.EventHandler(this.txtNama_TextChanged);
            // 
            // dgvMenu
            // 
            this.dgvMenu.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Location = new System.Drawing.Point(453, 62);
            this.dgvMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.RowHeadersWidth = 57;
            this.dgvMenu.RowTemplate.Height = 24;
            this.dgvMenu.Size = new System.Drawing.Size(529, 359);
            this.dgvMenu.TabIndex = 24;
            this.dgvMenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenu_CellContentClick);
            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(27, 121);
            this.txtHarga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(373, 32);
            this.txtHarga.TabIndex = 25;
            this.txtHarga.TextChanged += new System.EventHandler(this.txtHarga_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtHarga);
            this.groupBox1.Controls.Add(this.label2NamaMenu);
            this.groupBox1.Controls.Add(this.txtNama);
            this.groupBox1.Controls.Add(this.label1Harga);
            this.groupBox1.Font = new System.Drawing.Font("Myanmar Text", 6.985075F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 89);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(419, 178);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Form Tambah";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCariAdm);
            this.groupBox2.Controls.Add(this.txtHargaAdm);
            this.groupBox2.Controls.Add(this.cmbFilterBy);
            this.groupBox2.Location = new System.Drawing.Point(12, 274);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(419, 137);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter";
            // 
            // txtHargaAdm
            // 
            this.txtHargaAdm.Location = new System.Drawing.Point(165, 31);
            this.txtHargaAdm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHargaAdm.Name = "txtHargaAdm";
            this.txtHargaAdm.Size = new System.Drawing.Size(233, 22);
            this.txtHargaAdm.TabIndex = 28;
            // 
            // cmbFilterBy
            // 
            this.cmbFilterBy.FormattingEnabled = true;
            this.cmbFilterBy.Items.AddRange(new object[] {
            "Nasi Ayam",
            "Nasi Ikan",
            "Nasi Telur",
            "Nasi Udang"});
            this.cmbFilterBy.Location = new System.Drawing.Point(27, 31);
            this.cmbFilterBy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFilterBy.Name = "cmbFilterBy";
            this.cmbFilterBy.Size = new System.Drawing.Size(121, 24);
            this.cmbFilterBy.TabIndex = 0;
            // 
            // btnCariAdm
            // 
            this.btnCariAdm.Location = new System.Drawing.Point(27, 90);
            this.btnCariAdm.Name = "btnCariAdm";
            this.btnCariAdm.Size = new System.Drawing.Size(371, 23);
            this.btnCariAdm.TabIndex = 29;
            this.btnCariAdm.Text = "Cari";
            this.btnCariAdm.UseVisualStyleBackColor = true;
            this.btnCariAdm.Click += new System.EventHandler(this.btnCariAdm_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.Brown;
            this.btnPrev.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPrev.Location = new System.Drawing.Point(453, 439);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(100, 28);
            this.btnPrev.TabIndex = 28;
            this.btnPrev.Text = "Previous";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Brown;
            this.btnNext.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNext.Location = new System.Drawing.Point(561, 439);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 28);
            this.btnNext.TabIndex = 29;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblPageInfo
            // 
            this.lblPageInfo.AutoSize = true;
            this.lblPageInfo.Location = new System.Drawing.Point(920, 445);
            this.lblPageInfo.Name = "lblPageInfo";
            this.lblPageInfo.Size = new System.Drawing.Size(62, 16);
            this.lblPageInfo.TabIndex = 30;
            this.lblPageInfo.Text = "Halaman";
            // 
            // FormAdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1081, 567);
            this.Controls.Add(this.lblPageInfo);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvMenu);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.label1Menu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormAdminMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FormAdminMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2NamaMenu;
        private System.Windows.Forms.Label label1Harga;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1Menu;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbFilterBy;
        private System.Windows.Forms.TextBox txtHargaAdm;
        private System.Windows.Forms.Button btnCariAdm;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblPageInfo;
    }
}