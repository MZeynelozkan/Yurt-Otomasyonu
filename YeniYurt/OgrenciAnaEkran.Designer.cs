namespace YeniYurt
{
    partial class OgrenciAnaEkran
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.tutarBox = new System.Windows.Forms.TextBox();
            this.OdemeBTN = new System.Windows.Forms.Button();
            this.OgrenciID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AdSoyadBox = new System.Windows.Forms.TextBox();
            this.OdaBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BackBTN = new System.Windows.Forms.PictureBox();
            this.OdaFiyatBOX = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BackBTN)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(541, 136);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(541, 295);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker2.TabIndex = 1;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // tutarBox
            // 
            this.tutarBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutarBox.Location = new System.Drawing.Point(177, 358);
            this.tutarBox.Name = "tutarBox";
            this.tutarBox.Size = new System.Drawing.Size(200, 23);
            this.tutarBox.TabIndex = 2;
            this.tutarBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // OdemeBTN
            // 
            this.OdemeBTN.BackColor = System.Drawing.Color.White;
            this.OdemeBTN.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OdemeBTN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OdemeBTN.Location = new System.Drawing.Point(320, 452);
            this.OdemeBTN.Name = "OdemeBTN";
            this.OdemeBTN.Size = new System.Drawing.Size(273, 56);
            this.OdemeBTN.TabIndex = 3;
            this.OdemeBTN.Text = "ODEME YAP";
            this.OdemeBTN.UseVisualStyleBackColor = false;
            this.OdemeBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // OgrenciID
            // 
            this.OgrenciID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OgrenciID.Location = new System.Drawing.Point(177, 133);
            this.OgrenciID.Name = "OgrenciID";
            this.OgrenciID.Size = new System.Drawing.Size(200, 23);
            this.OgrenciID.TabIndex = 5;
            this.OgrenciID.TextChanged += new System.EventHandler(this.OgrencID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Odencek Tutar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ogrenci ID";
            // 
            // AdSoyadBox
            // 
            this.AdSoyadBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdSoyadBox.Location = new System.Drawing.Point(177, 184);
            this.AdSoyadBox.Name = "AdSoyadBox";
            this.AdSoyadBox.Size = new System.Drawing.Size(200, 23);
            this.AdSoyadBox.TabIndex = 8;
            this.AdSoyadBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // OdaBox
            // 
            this.OdaBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OdaBox.Location = new System.Drawing.Point(177, 237);
            this.OdaBox.Name = "OdaBox";
            this.OdaBox.Size = new System.Drawing.Size(200, 23);
            this.OdaBox.TabIndex = 9;
            this.OdaBox.TextChanged += new System.EventHandler(this.OdaBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "AD SOYAD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "ODA NO";
            // 
            // BackBTN
            // 
            this.BackBTN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackBTN.Image = global::YeniYurt.Properties.Resources.icons8_logout_rounded_left_50;
            this.BackBTN.Location = new System.Drawing.Point(-2, 0);
            this.BackBTN.Name = "BackBTN";
            this.BackBTN.Size = new System.Drawing.Size(47, 48);
            this.BackBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BackBTN.TabIndex = 20;
            this.BackBTN.TabStop = false;
            this.BackBTN.Click += new System.EventHandler(this.BackBTN_Click_1);
            // 
            // OdaFiyatBOX
            // 
            this.OdaFiyatBOX.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OdaFiyatBOX.Location = new System.Drawing.Point(177, 293);
            this.OdaFiyatBOX.Name = "OdaFiyatBOX";
            this.OdaFiyatBOX.Size = new System.Drawing.Size(200, 23);
            this.OdaFiyatBOX.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Odanin Fiyati";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(538, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "BUGUN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(538, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "SON OTURABILME TARIHI";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(171, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(547, 33);
            this.label8.TabIndex = 25;
            this.label8.Text = "YURT OTOMASYONU ODEME EKRANI";
            // 
            // OgrenciAnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(837, 553);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.OdaFiyatBOX);
            this.Controls.Add(this.BackBTN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OdaBox);
            this.Controls.Add(this.AdSoyadBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OgrenciID);
            this.Controls.Add(this.OdemeBTN);
            this.Controls.Add(this.tutarBox);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "OgrenciAnaEkran";
            this.Text = "OgrenciAnaEkran";
            this.Load += new System.EventHandler(this.OgrenciAnaEkran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BackBTN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox tutarBox;
        private System.Windows.Forms.Button OdemeBTN;
        private System.Windows.Forms.TextBox OgrenciID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AdSoyadBox;
        private System.Windows.Forms.TextBox OdaBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox BackBTN;
        private System.Windows.Forms.TextBox OdaFiyatBOX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}