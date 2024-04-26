namespace ProjeGreyder
{
    partial class Index
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.greyderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emirDataSet1 = new ProjeGreyder.emirDataSet1();
            this.urunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emirDataSet = new ProjeGreyder.emirDataSet();
            this.urunTableAdapter = new ProjeGreyder.emirDataSetTableAdapters.UrunTableAdapter();
            this.greyderTableAdapter = new ProjeGreyder.emirDataSet1TableAdapters.GreyderTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISIM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MARKA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEKERLEK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AGIRLIK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RENK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIYAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UZUNLUK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RESIM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.greyderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emirDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emirDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // greyderBindingSource
            // 
            this.greyderBindingSource.DataMember = "Greyder";
            this.greyderBindingSource.DataSource = this.emirDataSet1;
            // 
            // emirDataSet1
            // 
            this.emirDataSet1.DataSetName = "emirDataSet1";
            this.emirDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // urunBindingSource
            // 
            this.urunBindingSource.DataMember = "Urun";
            this.urunBindingSource.DataSource = this.emirDataSet;
            // 
            // emirDataSet
            // 
            this.emirDataSet.DataSetName = "emirDataSet";
            this.emirDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // urunTableAdapter
            // 
            this.urunTableAdapter.ClearBeforeFill = true;
            // 
            // greyderTableAdapter
            // 
            this.greyderTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(461, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "ANA SAYFA";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.SlateBlue;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ISIM,
            this.MODEL,
            this.MARKA,
            this.TEKERLEK,
            this.AGIRLIK,
            this.RENK,
            this.FIYAT,
            this.UZUNLUK,
            this.RESIM});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.Location = new System.Drawing.Point(28, 91);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.RowTemplate.Height = 70;
            this.dataGridView2.Size = new System.Drawing.Size(1070, 586);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // ISIM
            // 
            this.ISIM.DataPropertyName = "isim";
            this.ISIM.HeaderText = "ISIM";
            this.ISIM.Name = "ISIM";
            this.ISIM.ReadOnly = true;
            // 
            // MODEL
            // 
            this.MODEL.DataPropertyName = "model";
            this.MODEL.HeaderText = "MODEL";
            this.MODEL.Name = "MODEL";
            this.MODEL.ReadOnly = true;
            // 
            // MARKA
            // 
            this.MARKA.DataPropertyName = "marka";
            this.MARKA.HeaderText = "MARKA";
            this.MARKA.Name = "MARKA";
            this.MARKA.ReadOnly = true;
            // 
            // TEKERLEK
            // 
            this.TEKERLEK.DataPropertyName = "tekerlek";
            this.TEKERLEK.HeaderText = "TEKERLEK";
            this.TEKERLEK.Name = "TEKERLEK";
            this.TEKERLEK.ReadOnly = true;
            // 
            // AGIRLIK
            // 
            this.AGIRLIK.DataPropertyName = "agirlik";
            this.AGIRLIK.HeaderText = "AGIRLIK";
            this.AGIRLIK.Name = "AGIRLIK";
            this.AGIRLIK.ReadOnly = true;
            // 
            // RENK
            // 
            this.RENK.DataPropertyName = "renk";
            this.RENK.HeaderText = "RENK";
            this.RENK.Name = "RENK";
            this.RENK.ReadOnly = true;
            // 
            // FIYAT
            // 
            this.FIYAT.DataPropertyName = "fiyat";
            this.FIYAT.HeaderText = "FIYAT";
            this.FIYAT.Name = "FIYAT";
            this.FIYAT.ReadOnly = true;
            // 
            // UZUNLUK
            // 
            this.UZUNLUK.DataPropertyName = "uzunluk";
            this.UZUNLUK.HeaderText = "UZUNLUK";
            this.UZUNLUK.Name = "UZUNLUK";
            this.UZUNLUK.ReadOnly = true;
            // 
            // RESIM
            // 
            this.RESIM.DataPropertyName = "resim";
            this.RESIM.HeaderText = "RESIM";
            this.RESIM.Name = "RESIM";
            this.RESIM.ReadOnly = true;
            this.RESIM.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.OliveDrab;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(859, 699);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(239, 72);
            this.button2.TabIndex = 9;
            this.button2.Text = "Ekle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(614, 699);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 72);
            this.button1.TabIndex = 10;
            this.button1.Text = "Istatislik";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Index
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1134, 783);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Index";
            this.Load += new System.EventHandler(this.Index_Load);
            ((System.ComponentModel.ISupportInitialize)(this.greyderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emirDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emirDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private emirDataSet emirDataSet;
        private System.Windows.Forms.BindingSource urunBindingSource;
        private emirDataSetTableAdapters.UrunTableAdapter urunTableAdapter;
        private emirDataSet1 emirDataSet1;
        private System.Windows.Forms.BindingSource greyderBindingSource;
        private emirDataSet1TableAdapters.GreyderTableAdapter greyderTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISIM;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn MARKA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEKERLEK;
        private System.Windows.Forms.DataGridViewTextBoxColumn AGIRLIK;
        private System.Windows.Forms.DataGridViewTextBoxColumn RENK;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIYAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn UZUNLUK;
        private System.Windows.Forms.DataGridViewTextBoxColumn RESIM;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}