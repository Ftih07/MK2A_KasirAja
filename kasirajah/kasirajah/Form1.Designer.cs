namespace kasirajah
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbMinuman = new System.Windows.Forms.ComboBox();
            this.cbMakanan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtHargaMinuman = new System.Windows.Forms.TextBox();
            this.txtHargaMakanan = new System.Windows.Forms.TextBox();
            this.btProses = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.txtKembali = new System.Windows.Forms.TextBox();
            this.txtBayar = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtNamaKasir = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(36, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Warung Jawa";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbMinuman);
            this.groupBox1.Controls.Add(this.cbMakanan);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(45, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesan";
            // 
            // cbMinuman
            // 
            this.cbMinuman.FormattingEnabled = true;
            this.cbMinuman.Location = new System.Drawing.Point(73, 66);
            this.cbMinuman.Name = "cbMinuman";
            this.cbMinuman.Size = new System.Drawing.Size(121, 24);
            this.cbMinuman.TabIndex = 9;
            this.cbMinuman.SelectedIndexChanged += new System.EventHandler(this.cbMinuman_SelectedIndexChanged);
            // 
            // cbMakanan
            // 
            this.cbMakanan.FormattingEnabled = true;
            this.cbMakanan.Location = new System.Drawing.Point(73, 35);
            this.cbMakanan.Name = "cbMakanan";
            this.cbMakanan.Size = new System.Drawing.Size(121, 24);
            this.cbMakanan.TabIndex = 8;
            this.cbMakanan.SelectedIndexChanged += new System.EventHandler(this.cbMakanan_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Makanan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Minuman";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtHargaMinuman);
            this.groupBox2.Controls.Add(this.txtHargaMakanan);
            this.groupBox2.Location = new System.Drawing.Point(283, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(140, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Harga";
            // 
            // txtHargaMinuman
            // 
            this.txtHargaMinuman.Location = new System.Drawing.Point(18, 66);
            this.txtHargaMinuman.Name = "txtHargaMinuman";
            this.txtHargaMinuman.Size = new System.Drawing.Size(100, 22);
            this.txtHargaMinuman.TabIndex = 9;
            this.txtHargaMinuman.Text = "0";
            // 
            // txtHargaMakanan
            // 
            this.txtHargaMakanan.Location = new System.Drawing.Point(18, 35);
            this.txtHargaMakanan.Name = "txtHargaMakanan";
            this.txtHargaMakanan.Size = new System.Drawing.Size(100, 22);
            this.txtHargaMakanan.TabIndex = 8;
            this.txtHargaMakanan.Text = "0";
            // 
            // btProses
            // 
            this.btProses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProses.Location = new System.Drawing.Point(209, 335);
            this.btProses.Name = "btProses";
            this.btProses.Size = new System.Drawing.Size(100, 50);
            this.btProses.TabIndex = 24;
            this.btProses.Text = "Proses";
            this.btProses.UseVisualStyleBackColor = true;
            this.btProses.Click += new System.EventHandler(this.btProses_Click);
            // 
            // btClear
            // 
            this.btClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClear.Location = new System.Drawing.Point(103, 335);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(100, 50);
            this.btClear.TabIndex = 23;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // txtKembali
            // 
            this.txtKembali.Location = new System.Drawing.Point(281, 299);
            this.txtKembali.Name = "txtKembali";
            this.txtKembali.Size = new System.Drawing.Size(100, 22);
            this.txtKembali.TabIndex = 22;
            this.txtKembali.Text = "0";
            // 
            // txtBayar
            // 
            this.txtBayar.Location = new System.Drawing.Point(281, 271);
            this.txtBayar.Name = "txtBayar";
            this.txtBayar.Size = new System.Drawing.Size(100, 22);
            this.txtBayar.TabIndex = 21;
            this.txtBayar.Text = "0";
            this.txtBayar.TextChanged += new System.EventHandler(this.txtBayar_TextChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(281, 242);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 22);
            this.txtTotal.TabIndex = 19;
            this.txtTotal.Text = "0";
            // 
            // txtNamaKasir
            // 
            this.txtNamaKasir.Location = new System.Drawing.Point(62, 267);
            this.txtNamaKasir.Name = "txtNamaKasir";
            this.txtNamaKasir.Size = new System.Drawing.Size(100, 22);
            this.txtNamaKasir.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(206, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "KEMBALI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(206, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "BAYAR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "TOTAL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Nama Kasir";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btProses);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.txtKembali);
            this.Controls.Add(this.txtBayar);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtNamaKasir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbMinuman;
        private System.Windows.Forms.ComboBox cbMakanan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtHargaMinuman;
        private System.Windows.Forms.TextBox txtHargaMakanan;
        private System.Windows.Forms.Button btProses;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.TextBox txtKembali;
        private System.Windows.Forms.TextBox txtBayar;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtNamaKasir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

