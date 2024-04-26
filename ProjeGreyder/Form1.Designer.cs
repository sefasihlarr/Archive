namespace ProjeGreyder
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
            this.textisim = new System.Windows.Forms.TextBox();
            this.lblisim = new System.Windows.Forms.Label();
            this.lblmarka = new System.Windows.Forms.Label();
            this.textmarka = new System.Windows.Forms.TextBox();
            this.lblmodel = new System.Windows.Forms.Label();
            this.textmodel = new System.Windows.Forms.TextBox();
            this.lblagirlik = new System.Windows.Forms.Label();
            this.textagirlilk = new System.Windows.Forms.TextBox();
            this.lblrenk = new System.Windows.Forms.Label();
            this.textrenk = new System.Windows.Forms.TextBox();
            this.lbltekerlek = new System.Windows.Forms.Label();
            this.texttekerlek = new System.Windows.Forms.TextBox();
            this.lblfiyat = new System.Windows.Forms.Label();
            this.textfiyat = new System.Windows.Forms.TextBox();
            this.lbluzunluk = new System.Windows.Forms.Label();
            this.textuzunluk = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textresim = new System.Windows.Forms.TextBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnresimsec = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textisim
            // 
            this.textisim.Location = new System.Drawing.Point(90, 87);
            this.textisim.Name = "textisim";
            this.textisim.Size = new System.Drawing.Size(200, 20);
            this.textisim.TabIndex = 0;
            this.textisim.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textisim.Resize += new System.EventHandler(this.textisim_Resize);
            // 
            // lblisim
            // 
            this.lblisim.AutoSize = true;
            this.lblisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblisim.Location = new System.Drawing.Point(20, 85);
            this.lblisim.Name = "lblisim";
            this.lblisim.Size = new System.Drawing.Size(38, 20);
            this.lblisim.TabIndex = 1;
            this.lblisim.Text = "İsim";
            this.lblisim.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblmarka
            // 
            this.lblmarka.AutoSize = true;
            this.lblmarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmarka.Location = new System.Drawing.Point(21, 137);
            this.lblmarka.Name = "lblmarka";
            this.lblmarka.Size = new System.Drawing.Size(53, 20);
            this.lblmarka.TabIndex = 3;
            this.lblmarka.Text = "Marka";
            // 
            // textmarka
            // 
            this.textmarka.Location = new System.Drawing.Point(90, 139);
            this.textmarka.Name = "textmarka";
            this.textmarka.Size = new System.Drawing.Size(200, 20);
            this.textmarka.TabIndex = 2;
            // 
            // lblmodel
            // 
            this.lblmodel.AutoSize = true;
            this.lblmodel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmodel.Location = new System.Drawing.Point(20, 111);
            this.lblmodel.Name = "lblmodel";
            this.lblmodel.Size = new System.Drawing.Size(52, 20);
            this.lblmodel.TabIndex = 5;
            this.lblmodel.Text = "Model";
            // 
            // textmodel
            // 
            this.textmodel.Location = new System.Drawing.Point(90, 113);
            this.textmodel.Name = "textmodel";
            this.textmodel.Size = new System.Drawing.Size(200, 20);
            this.textmodel.TabIndex = 4;
            // 
            // lblagirlik
            // 
            this.lblagirlik.AutoSize = true;
            this.lblagirlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblagirlik.Location = new System.Drawing.Point(21, 189);
            this.lblagirlik.Name = "lblagirlik";
            this.lblagirlik.Size = new System.Drawing.Size(51, 20);
            this.lblagirlik.TabIndex = 11;
            this.lblagirlik.Text = "Ağırlık";
            // 
            // textagirlilk
            // 
            this.textagirlilk.Location = new System.Drawing.Point(90, 191);
            this.textagirlilk.Name = "textagirlilk";
            this.textagirlilk.Size = new System.Drawing.Size(200, 20);
            this.textagirlilk.TabIndex = 10;
            // 
            // lblrenk
            // 
            this.lblrenk.AutoSize = true;
            this.lblrenk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrenk.Location = new System.Drawing.Point(21, 215);
            this.lblrenk.Name = "lblrenk";
            this.lblrenk.Size = new System.Drawing.Size(47, 20);
            this.lblrenk.TabIndex = 9;
            this.lblrenk.Text = "Renk";
            // 
            // textrenk
            // 
            this.textrenk.Location = new System.Drawing.Point(90, 217);
            this.textrenk.Name = "textrenk";
            this.textrenk.Size = new System.Drawing.Size(200, 20);
            this.textrenk.TabIndex = 8;
            // 
            // lbltekerlek
            // 
            this.lbltekerlek.AutoSize = true;
            this.lbltekerlek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltekerlek.Location = new System.Drawing.Point(20, 163);
            this.lbltekerlek.Name = "lbltekerlek";
            this.lbltekerlek.Size = new System.Drawing.Size(69, 20);
            this.lbltekerlek.TabIndex = 7;
            this.lbltekerlek.Text = "Tekerlek";
            // 
            // texttekerlek
            // 
            this.texttekerlek.Location = new System.Drawing.Point(90, 165);
            this.texttekerlek.Name = "texttekerlek";
            this.texttekerlek.Size = new System.Drawing.Size(200, 20);
            this.texttekerlek.TabIndex = 6;
            // 
            // lblfiyat
            // 
            this.lblfiyat.AutoSize = true;
            this.lblfiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfiyat.Location = new System.Drawing.Point(21, 241);
            this.lblfiyat.Name = "lblfiyat";
            this.lblfiyat.Size = new System.Drawing.Size(43, 20);
            this.lblfiyat.TabIndex = 13;
            this.lblfiyat.Text = "Fiyat";
            // 
            // textfiyat
            // 
            this.textfiyat.Location = new System.Drawing.Point(90, 243);
            this.textfiyat.Name = "textfiyat";
            this.textfiyat.Size = new System.Drawing.Size(200, 20);
            this.textfiyat.TabIndex = 12;
            // 
            // lbluzunluk
            // 
            this.lbluzunluk.AutoSize = true;
            this.lbluzunluk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluzunluk.Location = new System.Drawing.Point(20, 270);
            this.lbluzunluk.Name = "lbluzunluk";
            this.lbluzunluk.Size = new System.Drawing.Size(67, 20);
            this.lbluzunluk.TabIndex = 15;
            this.lbluzunluk.Text = "Uzunluk";
            // 
            // textuzunluk
            // 
            this.textuzunluk.Location = new System.Drawing.Point(90, 270);
            this.textuzunluk.Name = "textuzunluk";
            this.textuzunluk.Size = new System.Drawing.Size(200, 20);
            this.textuzunluk.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Resim";
            // 
            // textresim
            // 
            this.textresim.Location = new System.Drawing.Point(90, 296);
            this.textresim.Name = "textresim";
            this.textresim.Size = new System.Drawing.Size(200, 20);
            this.textresim.TabIndex = 18;
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.Chartreuse;
            this.btnekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnekle.ForeColor = System.Drawing.Color.White;
            this.btnekle.Location = new System.Drawing.Point(438, 356);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(214, 72);
            this.btnekle.TabIndex = 20;
            this.btnekle.Text = "Kaydet";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnresimsec
            // 
            this.btnresimsec.BackColor = System.Drawing.Color.LightCoral;
            this.btnresimsec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresimsec.Location = new System.Drawing.Point(298, 288);
            this.btnresimsec.Name = "btnresimsec";
            this.btnresimsec.Size = new System.Drawing.Size(99, 28);
            this.btnresimsec.TabIndex = 22;
            this.btnresimsec.Text = "Resim Seç";
            this.btnresimsec.UseVisualStyleBackColor = false;
            this.btnresimsec.Click += new System.EventHandler(this.btnresimsec_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(298, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(481, 191);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(668, 356);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(223, 72);
            this.button2.TabIndex = 24;
            this.button2.Text = "Çıkış";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(407, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 39);
            this.label1.TabIndex = 25;
            this.label1.Text = "Ekle";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(903, 464);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnresimsec);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textresim);
            this.Controls.Add(this.lbluzunluk);
            this.Controls.Add(this.textuzunluk);
            this.Controls.Add(this.lblfiyat);
            this.Controls.Add(this.textfiyat);
            this.Controls.Add(this.lblagirlik);
            this.Controls.Add(this.textagirlilk);
            this.Controls.Add(this.lblrenk);
            this.Controls.Add(this.textrenk);
            this.Controls.Add(this.lbltekerlek);
            this.Controls.Add(this.texttekerlek);
            this.Controls.Add(this.lblmodel);
            this.Controls.Add(this.textmodel);
            this.Controls.Add(this.lblmarka);
            this.Controls.Add(this.textmarka);
            this.Controls.Add(this.lblisim);
            this.Controls.Add(this.textisim);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textisim;
        private System.Windows.Forms.Label lblisim;
        private System.Windows.Forms.Label lblmarka;
        private System.Windows.Forms.TextBox textmarka;
        private System.Windows.Forms.Label lblmodel;
        private System.Windows.Forms.TextBox textmodel;
        private System.Windows.Forms.Label lblagirlik;
        private System.Windows.Forms.TextBox textagirlilk;
        private System.Windows.Forms.Label lblrenk;
        private System.Windows.Forms.TextBox textrenk;
        private System.Windows.Forms.Label lbltekerlek;
        private System.Windows.Forms.TextBox texttekerlek;
        private System.Windows.Forms.Label lblfiyat;
        private System.Windows.Forms.TextBox textfiyat;
        private System.Windows.Forms.Label lbluzunluk;
        private System.Windows.Forms.TextBox textuzunluk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textresim;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnresimsec;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}

