namespace ProjeGreyder
{
    partial class Istatislik
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend15 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea16 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend16 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.marka = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Toplam = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.model = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tekerlek = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.agirlik = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.fiyat = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.uzunluk = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.renk = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.marka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Toplam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.model)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tekerlek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agirlik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uzunluk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.renk)).BeginInit();
            this.SuspendLayout();
            // 
            // marka
            // 
            chartArea9.Name = "ChartArea1";
            this.marka.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.marka.Legends.Add(legend9);
            this.marka.Location = new System.Drawing.Point(356, 35);
            this.marka.Name = "marka";
            series9.ChartArea = "ChartArea1";
            series9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series9.Legend = "Legend1";
            series9.Name = "Greyder";
            this.marka.Series.Add(series9);
            this.marka.Size = new System.Drawing.Size(317, 215);
            this.marka.TabIndex = 0;
            this.marka.Text = "chart1";
            this.marka.Click += new System.EventHandler(this.chart1_Click);
            // 
            // Toplam
            // 
            chartArea10.Name = "ChartArea1";
            this.Toplam.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.Toplam.Legends.Add(legend10);
            this.Toplam.Location = new System.Drawing.Point(25, 35);
            this.Toplam.Name = "Toplam";
            series10.ChartArea = "ChartArea1";
            series10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series10.Legend = "Legend1";
            series10.Name = "Greyder";
            this.Toplam.Series.Add(series10);
            this.Toplam.Size = new System.Drawing.Size(322, 215);
            this.Toplam.TabIndex = 1;
            this.Toplam.Text = "chart2";
            // 
            // model
            // 
            chartArea11.Name = "ChartArea1";
            this.model.ChartAreas.Add(chartArea11);
            legend11.Name = "Legend1";
            this.model.Legends.Add(legend11);
            this.model.Location = new System.Drawing.Point(679, 35);
            this.model.Name = "model";
            series11.ChartArea = "ChartArea1";
            series11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series11.Legend = "Legend1";
            series11.Name = "Greyder";
            this.model.Series.Add(series11);
            this.model.Size = new System.Drawing.Size(329, 215);
            this.model.TabIndex = 2;
            this.model.Text = "model";
            // 
            // tekerlek
            // 
            chartArea12.Name = "ChartArea1";
            this.tekerlek.ChartAreas.Add(chartArea12);
            legend12.Name = "Legend1";
            this.tekerlek.Legends.Add(legend12);
            this.tekerlek.Location = new System.Drawing.Point(1014, 35);
            this.tekerlek.Name = "tekerlek";
            series12.ChartArea = "ChartArea1";
            series12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series12.Legend = "Legend1";
            series12.Name = "Greyder";
            this.tekerlek.Series.Add(series12);
            this.tekerlek.Size = new System.Drawing.Size(323, 215);
            this.tekerlek.TabIndex = 4;
            this.tekerlek.Text = "chart5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(483, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Marka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Toplam Ürün";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // agirlik
            // 
            chartArea13.Name = "ChartArea1";
            this.agirlik.ChartAreas.Add(chartArea13);
            legend13.Name = "Legend1";
            this.agirlik.Legends.Add(legend13);
            this.agirlik.Location = new System.Drawing.Point(30, 308);
            this.agirlik.Name = "agirlik";
            series13.ChartArea = "ChartArea1";
            series13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series13.Legend = "Legend1";
            series13.Name = "Greyder";
            this.agirlik.Series.Add(series13);
            this.agirlik.Size = new System.Drawing.Size(317, 215);
            this.agirlik.TabIndex = 0;
            this.agirlik.Text = "chart1";
            this.agirlik.Click += new System.EventHandler(this.chart1_Click);
            // 
            // fiyat
            // 
            chartArea14.Name = "ChartArea1";
            this.fiyat.ChartAreas.Add(chartArea14);
            legend14.Name = "Legend1";
            this.fiyat.Legends.Add(legend14);
            this.fiyat.Location = new System.Drawing.Point(351, 308);
            this.fiyat.Name = "fiyat";
            series14.ChartArea = "ChartArea1";
            series14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series14.Legend = "Legend1";
            series14.Name = "Greyder";
            this.fiyat.Series.Add(series14);
            this.fiyat.Size = new System.Drawing.Size(322, 215);
            this.fiyat.TabIndex = 1;
            this.fiyat.Text = "chart2";
            // 
            // uzunluk
            // 
            chartArea15.Name = "ChartArea1";
            this.uzunluk.ChartAreas.Add(chartArea15);
            legend15.Name = "Legend1";
            this.uzunluk.Legends.Add(legend15);
            this.uzunluk.Location = new System.Drawing.Point(679, 308);
            this.uzunluk.Name = "uzunluk";
            series15.ChartArea = "ChartArea1";
            series15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series15.Legend = "Legend1";
            series15.Name = "Greyder";
            this.uzunluk.Series.Add(series15);
            this.uzunluk.Size = new System.Drawing.Size(329, 215);
            this.uzunluk.TabIndex = 2;
            this.uzunluk.Text = "chart3";
            // 
            // renk
            // 
            chartArea16.Name = "ChartArea1";
            this.renk.ChartAreas.Add(chartArea16);
            legend16.Name = "Legend1";
            this.renk.Legends.Add(legend16);
            this.renk.Location = new System.Drawing.Point(1014, 308);
            this.renk.Name = "renk";
            series16.ChartArea = "ChartArea1";
            series16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series16.Legend = "Legend1";
            series16.Name = "Greyder";
            this.renk.Series.Add(series16);
            this.renk.Size = new System.Drawing.Size(323, 215);
            this.renk.TabIndex = 4;
            this.renk.Text = "chart5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(803, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Model";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1152, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tekerlek";
            this.label5.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(143, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ağırlık";
            this.label6.Click += new System.EventHandler(this.label3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(494, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Fiyat";
            this.label7.Click += new System.EventHandler(this.label3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(814, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Uzunluk";
            this.label8.Click += new System.EventHandler(this.label3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1152, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 18);
            this.label9.TabIndex = 7;
            this.label9.Text = "Renk";
            this.label9.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1098, 553);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 72);
            this.button1.TabIndex = 8;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Istatislik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 689);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.renk);
            this.Controls.Add(this.tekerlek);
            this.Controls.Add(this.uzunluk);
            this.Controls.Add(this.model);
            this.Controls.Add(this.fiyat);
            this.Controls.Add(this.Toplam);
            this.Controls.Add(this.agirlik);
            this.Controls.Add(this.marka);
            this.Name = "Istatislik";
            this.Text = "Istatislik";
            this.Load += new System.EventHandler(this.Istatislik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.marka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Toplam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.model)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tekerlek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agirlik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uzunluk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.renk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart marka;
        private System.Windows.Forms.DataVisualization.Charting.Chart Toplam;
        private System.Windows.Forms.DataVisualization.Charting.Chart model;
        private System.Windows.Forms.DataVisualization.Charting.Chart tekerlek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart agirlik;
        private System.Windows.Forms.DataVisualization.Charting.Chart fiyat;
        private System.Windows.Forms.DataVisualization.Charting.Chart uzunluk;
        private System.Windows.Forms.DataVisualization.Charting.Chart renk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
    }
}