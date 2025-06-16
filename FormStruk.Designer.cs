namespace HoloSouls_PDKR_NSPD
{
    partial class FormStruk
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
            this.dgvStruk = new System.Windows.Forms.DataGridView();
            this.lblStrukItem = new System.Windows.Forms.Label();
            this.lblStrukTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStruk)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStruk
            // 
            this.dgvStruk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStruk.Location = new System.Drawing.Point(29, 67);
            this.dgvStruk.Name = "dgvStruk";
            this.dgvStruk.RowHeadersWidth = 57;
            this.dgvStruk.RowTemplate.Height = 24;
            this.dgvStruk.Size = new System.Drawing.Size(452, 237);
            this.dgvStruk.TabIndex = 0;
            // 
            // lblStrukItem
            // 
            this.lblStrukItem.AutoSize = true;
            this.lblStrukItem.Location = new System.Drawing.Point(67, 343);
            this.lblStrukItem.Name = "lblStrukItem";
            this.lblStrukItem.Size = new System.Drawing.Size(44, 16);
            this.lblStrukItem.TabIndex = 1;
            this.lblStrukItem.Text = "label1";
            // 
            // lblStrukTotal
            // 
            this.lblStrukTotal.AutoSize = true;
            this.lblStrukTotal.Location = new System.Drawing.Point(67, 388);
            this.lblStrukTotal.Name = "lblStrukTotal";
            this.lblStrukTotal.Size = new System.Drawing.Size(44, 16);
            this.lblStrukTotal.TabIndex = 2;
            this.lblStrukTotal.Text = "label2";
            // 
            // FormStruk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 569);
            this.Controls.Add(this.lblStrukTotal);
            this.Controls.Add(this.lblStrukItem);
            this.Controls.Add(this.dgvStruk);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormStruk";
            this.Text = "Form_Struk";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStruk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStruk;
        private System.Windows.Forms.Label lblStrukItem;
        private System.Windows.Forms.Label lblStrukTotal;
    }
}