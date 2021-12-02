
namespace Calculator
{
    partial class FrmEntryCalculator
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
            this.lblNilaiA = new System.Windows.Forms.Label();
            this.lblNilaiB = new System.Windows.Forms.Label();
            this.cmbOperasi = new System.Windows.Forms.ComboBox();
            this.txtNilaiA = new System.Windows.Forms.TextBox();
            this.btnProses = new System.Windows.Forms.Button();
            this.lblOperasi = new System.Windows.Forms.Label();
            this.txtNilaiB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNilaiA
            // 
            this.lblNilaiA.AutoSize = true;
            this.lblNilaiA.Location = new System.Drawing.Point(12, 46);
            this.lblNilaiA.Name = "lblNilaiA";
            this.lblNilaiA.Size = new System.Drawing.Size(48, 17);
            this.lblNilaiA.TabIndex = 1;
            this.lblNilaiA.Text = "Nilai A";
            // 
            // lblNilaiB
            // 
            this.lblNilaiB.AutoSize = true;
            this.lblNilaiB.Location = new System.Drawing.Point(12, 80);
            this.lblNilaiB.Name = "lblNilaiB";
            this.lblNilaiB.Size = new System.Drawing.Size(48, 17);
            this.lblNilaiB.TabIndex = 2;
            this.lblNilaiB.Text = "Nilai B";
            // 
            // cmbOperasi
            // 
            this.cmbOperasi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperasi.FormattingEnabled = true;
            this.cmbOperasi.Items.AddRange(new object[] {
            "Penjumlahan",
            "Pengurangan",
            "Perkalian",
            "Pembagian"});
            this.cmbOperasi.Location = new System.Drawing.Point(92, 6);
            this.cmbOperasi.Name = "cmbOperasi";
            this.cmbOperasi.Size = new System.Drawing.Size(154, 24);
            this.cmbOperasi.TabIndex = 3;
            // 
            // txtNilaiA
            // 
            this.txtNilaiA.Location = new System.Drawing.Point(92, 43);
            this.txtNilaiA.Name = "txtNilaiA";
            this.txtNilaiA.Size = new System.Drawing.Size(154, 22);
            this.txtNilaiA.TabIndex = 4;
            // 
            // btnProses
            // 
            this.btnProses.Location = new System.Drawing.Point(156, 119);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(90, 29);
            this.btnProses.TabIndex = 6;
            this.btnProses.Text = "Proses";
            this.btnProses.UseVisualStyleBackColor = true;
            this.btnProses.Click += new System.EventHandler(this.btnProses_Click);
            // 
            // lblOperasi
            // 
            this.lblOperasi.AutoSize = true;
            this.lblOperasi.Location = new System.Drawing.Point(12, 9);
            this.lblOperasi.Name = "lblOperasi";
            this.lblOperasi.Size = new System.Drawing.Size(58, 17);
            this.lblOperasi.TabIndex = 7;
            this.lblOperasi.Text = "Operasi";
            // 
            // txtNilaiB
            // 
            this.txtNilaiB.Location = new System.Drawing.Point(92, 77);
            this.txtNilaiB.Name = "txtNilaiB";
            this.txtNilaiB.Size = new System.Drawing.Size(154, 22);
            this.txtNilaiB.TabIndex = 8;
            // 
            // FrmEntryCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 160);
            this.Controls.Add(this.txtNilaiB);
            this.Controls.Add(this.lblOperasi);
            this.Controls.Add(this.btnProses);
            this.Controls.Add(this.txtNilaiA);
            this.Controls.Add(this.cmbOperasi);
            this.Controls.Add(this.lblNilaiB);
            this.Controls.Add(this.lblNilaiA);
            this.Name = "FrmEntryCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNilaiA;
        private System.Windows.Forms.Label lblNilaiB;
        private System.Windows.Forms.ComboBox cmbOperasi;
        private System.Windows.Forms.TextBox txtNilaiA;
        private System.Windows.Forms.Button btnProses;
        private System.Windows.Forms.Label lblOperasi;
        private System.Windows.Forms.TextBox txtNilaiB;
    }
}