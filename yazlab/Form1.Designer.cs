namespace yazlab
{
    partial class ana_menu
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dosyadan_oku = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtW = new System.Windows.Forms.TextBox();
            this.txtH = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bmp_kaydet = new System.Windows.Forms.Button();
            this.oynat = new System.Windows.Forms.Button();
            this.durdur = new System.Windows.Forms.Button();
            this.sifirla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dosyadan_oku
            // 
            this.dosyadan_oku.Cursor = System.Windows.Forms.Cursors.Default;
            this.dosyadan_oku.Enabled = false;
            this.dosyadan_oku.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dosyadan_oku.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dosyadan_oku.Location = new System.Drawing.Point(771, 194);
            this.dosyadan_oku.Name = "dosyadan_oku";
            this.dosyadan_oku.Size = new System.Drawing.Size(140, 36);
            this.dosyadan_oku.TabIndex = 0;
            this.dosyadan_oku.Text = "Dosyadan Oku";
            this.dosyadan_oku.UseVisualStyleBackColor = true;
            this.dosyadan_oku.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 29);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(720, 576);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(256, 256);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(592, 630);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "Dosyadan Seç";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(12, 631);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(559, 27);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(756, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Width:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(749, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Height:";
            // 
            // txtW
            // 
            this.txtW.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtW.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtW.Location = new System.Drawing.Point(835, 29);
            this.txtW.Multiline = true;
            this.txtW.Name = "txtW";
            this.txtW.Size = new System.Drawing.Size(76, 27);
            this.txtW.TabIndex = 7;
            this.txtW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtW_KeyPress);
            // 
            // txtH
            // 
            this.txtH.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtH.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtH.Location = new System.Drawing.Point(835, 74);
            this.txtH.Multiline = true;
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(76, 27);
            this.txtH.TabIndex = 8;
            this.txtH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtH_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "4-4-4",
            "4-2-2",
            "4-2-0"});
            this.comboBox1.Location = new System.Drawing.Point(835, 137);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(76, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(749, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Format:";
            // 
            // bmp_kaydet
            // 
            this.bmp_kaydet.Cursor = System.Windows.Forms.Cursors.Default;
            this.bmp_kaydet.Enabled = false;
            this.bmp_kaydet.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bmp_kaydet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bmp_kaydet.Location = new System.Drawing.Point(771, 362);
            this.bmp_kaydet.Name = "bmp_kaydet";
            this.bmp_kaydet.Size = new System.Drawing.Size(140, 36);
            this.bmp_kaydet.TabIndex = 11;
            this.bmp_kaydet.Text = "Bmp Kaydet";
            this.bmp_kaydet.UseVisualStyleBackColor = true;
            this.bmp_kaydet.Click += new System.EventHandler(this.button3_Click);
            // 
            // oynat
            // 
            this.oynat.Cursor = System.Windows.Forms.Cursors.Default;
            this.oynat.Enabled = false;
            this.oynat.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oynat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.oynat.Location = new System.Drawing.Point(771, 253);
            this.oynat.Name = "oynat";
            this.oynat.Size = new System.Drawing.Size(140, 36);
            this.oynat.TabIndex = 12;
            this.oynat.Text = "Oynat";
            this.oynat.UseVisualStyleBackColor = true;
            this.oynat.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // durdur
            // 
            this.durdur.Cursor = System.Windows.Forms.Cursors.Default;
            this.durdur.Enabled = false;
            this.durdur.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.durdur.ForeColor = System.Drawing.SystemColors.ControlText;
            this.durdur.Location = new System.Drawing.Point(771, 307);
            this.durdur.Name = "durdur";
            this.durdur.Size = new System.Drawing.Size(140, 36);
            this.durdur.TabIndex = 13;
            this.durdur.Text = "Durdur";
            this.durdur.UseVisualStyleBackColor = true;
            this.durdur.Click += new System.EventHandler(this.button4_Click);
            // 
            // sifirla
            // 
            this.sifirla.Cursor = System.Windows.Forms.Cursors.Default;
            this.sifirla.Enabled = false;
            this.sifirla.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifirla.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sifirla.Location = new System.Drawing.Point(771, 414);
            this.sifirla.Name = "sifirla";
            this.sifirla.Size = new System.Drawing.Size(140, 36);
            this.sifirla.TabIndex = 14;
            this.sifirla.Text = "Sıfırla";
            this.sifirla.UseVisualStyleBackColor = true;
            this.sifirla.Click += new System.EventHandler(this.sifirla_Click);
            // 
            // ana_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(959, 680);
            this.Controls.Add(this.sifirla);
            this.Controls.Add(this.durdur);
            this.Controls.Add(this.oynat);
            this.Controls.Add(this.bmp_kaydet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.txtW);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.dosyadan_oku);
            this.Name = "ana_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Menü";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dosyadan_oku;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtW;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bmp_kaydet;
        private System.Windows.Forms.Button oynat;
        private System.Windows.Forms.Button durdur;
        private System.Windows.Forms.Button sifirla;
    }
}

