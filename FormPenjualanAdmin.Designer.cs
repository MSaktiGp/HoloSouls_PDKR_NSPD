namespace HoloSouls_PDKR_NSPD
{
    partial class FormPenjualanAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPenjualanAdmin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvPenjualan = new System.Windows.Forms.DataGridView();
            this.btnCetak = new System.Windows.Forms.Button();
            this.label1DataPenjualan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPenjualan)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(564, 521);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dgvPenjualan
            // 
            this.dgvPenjualan.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPenjualan.Location = new System.Drawing.Point(30, 68);
            this.dgvPenjualan.Name = "dgvPenjualan";
            this.dgvPenjualan.Size = new System.Drawing.Size(506, 405);
            this.dgvPenjualan.TabIndex = 1;
            // 
            // btnCetak
            // 
            this.btnCetak.BackColor = System.Drawing.Color.Maroon;
            this.btnCetak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCetak.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCetak.Location = new System.Drawing.Point(463, 484);
            this.btnCetak.Name = "btnCetak";
            this.btnCetak.Size = new System.Drawing.Size(75, 29);
            this.btnCetak.TabIndex = 2;
            this.btnCetak.Text = "Cetak";
            this.btnCetak.UseVisualStyleBackColor = false;
            this.btnCetak.Click += new System.EventHandler(this.btnCetak_Click);
            // 
            // label1DataPenjualan
            // 
            this.label1DataPenjualan.AutoSize = true;
            this.label1DataPenjualan.BackColor = System.Drawing.Color.Maroon;
            this.label1DataPenjualan.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1DataPenjualan.ForeColor = System.Drawing.SystemColors.Control;
            this.label1DataPenjualan.Location = new System.Drawing.Point(181, 26);
            this.label1DataPenjualan.Name = "label1DataPenjualan";
            this.label1DataPenjualan.Size = new System.Drawing.Size(201, 28);
            this.label1DataPenjualan.TabIndex = 3;
            this.label1DataPenjualan.Text = "Data Penjualan";
            // 
            // FormPenjualanAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 516);
            this.Controls.Add(this.label1DataPenjualan);
            this.Controls.Add(this.btnCetak);
            this.Controls.Add(this.dgvPenjualan);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormPenjualanAdmin";
            this.Text = "Data Penjualan";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPenjualan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvPenjualan;
        private System.Windows.Forms.Button btnCetak;
        private System.Windows.Forms.Label label1DataPenjualan;
    }
}