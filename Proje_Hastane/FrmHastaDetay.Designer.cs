namespace Proje_Hastane
{
    partial class FrmHastaDetay
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
            this.groupBox1Ha = new System.Windows.Forms.GroupBox();
            this.LblAdSoyad = new System.Windows.Forms.Label();
            this.LblTc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnRandevuAl = new System.Windows.Forms.Button();
            this.RTxtSikayet = new System.Windows.Forms.RichTextBox();
            this.CmbDoktor = new System.Windows.Forms.ComboBox();
            this.CmbBrans = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.LnkBilgiDuzenle = new System.Windows.Forms.LinkLabel();
            this.groupBox1Ha.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1Ha
            // 
            this.groupBox1Ha.Controls.Add(this.LblAdSoyad);
            this.groupBox1Ha.Controls.Add(this.LblTc);
            this.groupBox1Ha.Controls.Add(this.label2);
            this.groupBox1Ha.Controls.Add(this.label1);
            this.groupBox1Ha.Location = new System.Drawing.Point(12, 12);
            this.groupBox1Ha.Name = "groupBox1Ha";
            this.groupBox1Ha.Size = new System.Drawing.Size(388, 179);
            this.groupBox1Ha.TabIndex = 0;
            this.groupBox1Ha.TabStop = false;
            this.groupBox1Ha.Text = "Hasta Bilgileri";
            // 
            // LblAdSoyad
            // 
            this.LblAdSoyad.AutoSize = true;
            this.LblAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAdSoyad.Location = new System.Drawing.Point(175, 85);
            this.LblAdSoyad.Name = "LblAdSoyad";
            this.LblAdSoyad.Size = new System.Drawing.Size(101, 25);
            this.LblAdSoyad.TabIndex = 3;
            this.LblAdSoyad.Text = "Null Null";
            // 
            // LblTc
            // 
            this.LblTc.AutoSize = true;
            this.LblTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTc.Location = new System.Drawing.Point(175, 43);
            this.LblTc.Name = "LblTc";
            this.LblTc.Size = new System.Drawing.Size(155, 25);
            this.LblTc.TabIndex = 2;
            this.LblTc.Text = "00000000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(39, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(104, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LnkBilgiDuzenle);
            this.groupBox1.Controls.Add(this.BtnRandevuAl);
            this.groupBox1.Controls.Add(this.RTxtSikayet);
            this.groupBox1.Controls.Add(this.CmbDoktor);
            this.groupBox1.Controls.Add(this.CmbBrans);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 337);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Randevu Sistemi";
            // 
            // BtnRandevuAl
            // 
            this.BtnRandevuAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnRandevuAl.Location = new System.Drawing.Point(136, 275);
            this.BtnRandevuAl.Name = "BtnRandevuAl";
            this.BtnRandevuAl.Size = new System.Drawing.Size(226, 45);
            this.BtnRandevuAl.TabIndex = 10;
            this.BtnRandevuAl.Text = "Randevu Al";
            this.BtnRandevuAl.UseVisualStyleBackColor = true;
            // 
            // RTxtSikayet
            // 
            this.RTxtSikayet.Location = new System.Drawing.Point(136, 153);
            this.RTxtSikayet.Name = "RTxtSikayet";
            this.RTxtSikayet.Size = new System.Drawing.Size(223, 116);
            this.RTxtSikayet.TabIndex = 9;
            this.RTxtSikayet.Text = "";
            // 
            // CmbDoktor
            // 
            this.CmbDoktor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbDoktor.FormattingEnabled = true;
            this.CmbDoktor.Location = new System.Drawing.Point(136, 107);
            this.CmbDoktor.Name = "CmbDoktor";
            this.CmbDoktor.Size = new System.Drawing.Size(223, 33);
            this.CmbDoktor.TabIndex = 8;
            // 
            // CmbBrans
            // 
            this.CmbBrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbBrans.FormattingEnabled = true;
            this.CmbBrans.Location = new System.Drawing.Point(136, 59);
            this.CmbBrans.Name = "CmbBrans";
            this.CmbBrans.Size = new System.Drawing.Size(223, 33);
            this.CmbBrans.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(33, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Şikayet:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(42, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Doktor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(50, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Branş:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(406, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(703, 179);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Gemişi";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Location = new System.Drawing.Point(406, 206);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(717, 337);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Aktif Randevular";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(697, 160);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(711, 318);
            this.dataGridView2.TabIndex = 0;
            // 
            // LnkBilgiDuzenle
            // 
            this.LnkBilgiDuzenle.AutoSize = true;
            this.LnkBilgiDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LnkBilgiDuzenle.Location = new System.Drawing.Point(17, 292);
            this.LnkBilgiDuzenle.Name = "LnkBilgiDuzenle";
            this.LnkBilgiDuzenle.Size = new System.Drawing.Size(113, 16);
            this.LnkBilgiDuzenle.TabIndex = 11;
            this.LnkBilgiDuzenle.TabStop = true;
            this.LnkBilgiDuzenle.Text = "Bilgilerini Düzenle";
            // 
            // FrmHastaDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1121, 555);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox1Ha);
            this.Name = "FrmHastaDetay";
            this.Text = "FrmHastaDetay";
            this.groupBox1Ha.ResumeLayout(false);
            this.groupBox1Ha.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1Ha;
        private System.Windows.Forms.Label LblAdSoyad;
        private System.Windows.Forms.Label LblTc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnRandevuAl;
        private System.Windows.Forms.RichTextBox RTxtSikayet;
        private System.Windows.Forms.ComboBox CmbDoktor;
        private System.Windows.Forms.ComboBox CmbBrans;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.LinkLabel LnkBilgiDuzenle;
    }
}