namespace YeniYurt
{
    partial class OdaEkleme
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
            this.OdaNumarasiBOX = new System.Windows.Forms.TextBox();
            this.OdaKapasiteBox = new System.Windows.Forms.TextBox();
            this.OdaKatiBOX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BackBTN = new System.Windows.Forms.PictureBox();
            this.OdayiEklemeBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BackBTN)).BeginInit();
            this.SuspendLayout();
            // 
            // OdaNumarasiBOX
            // 
            this.OdaNumarasiBOX.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OdaNumarasiBOX.Location = new System.Drawing.Point(304, 48);
            this.OdaNumarasiBOX.Name = "OdaNumarasiBOX";
            this.OdaNumarasiBOX.Size = new System.Drawing.Size(100, 23);
            this.OdaNumarasiBOX.TabIndex = 0;
            this.OdaNumarasiBOX.TextChanged += new System.EventHandler(this.OdaNumarasiBOX_TextChanged);
            // 
            // OdaKapasiteBox
            // 
            this.OdaKapasiteBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OdaKapasiteBox.Location = new System.Drawing.Point(304, 167);
            this.OdaKapasiteBox.Name = "OdaKapasiteBox";
            this.OdaKapasiteBox.Size = new System.Drawing.Size(100, 23);
            this.OdaKapasiteBox.TabIndex = 1;
            this.OdaKapasiteBox.TextChanged += new System.EventHandler(this.OdaKapasiteBox_TextChanged);
            // 
            // OdaKatiBOX
            // 
            this.OdaKatiBOX.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OdaKatiBOX.Location = new System.Drawing.Point(304, 109);
            this.OdaKatiBOX.Name = "OdaKatiBOX";
            this.OdaKatiBOX.Size = new System.Drawing.Size(100, 23);
            this.OdaKatiBOX.TabIndex = 2;
            this.OdaKatiBOX.TextChanged += new System.EventHandler(this.OdaKatiBOX_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Oda Numarasi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(138, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Oda Kati";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(138, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Oda Kisi Kapasitesi";
            // 
            // BackBTN
            // 
            this.BackBTN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackBTN.Image = global::YeniYurt.Properties.Resources.icons8_logout_rounded_left_50;
            this.BackBTN.Location = new System.Drawing.Point(-1, 0);
            this.BackBTN.Name = "BackBTN";
            this.BackBTN.Size = new System.Drawing.Size(47, 48);
            this.BackBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BackBTN.TabIndex = 20;
            this.BackBTN.TabStop = false;
            this.BackBTN.Click += new System.EventHandler(this.BackBTN_Click);
            // 
            // OdayiEklemeBTN
            // 
            this.OdayiEklemeBTN.BackColor = System.Drawing.Color.White;
            this.OdayiEklemeBTN.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OdayiEklemeBTN.Location = new System.Drawing.Point(379, 229);
            this.OdayiEklemeBTN.Name = "OdayiEklemeBTN";
            this.OdayiEklemeBTN.Size = new System.Drawing.Size(107, 46);
            this.OdayiEklemeBTN.TabIndex = 21;
            this.OdayiEklemeBTN.Text = "Odayi Ekle";
            this.OdayiEklemeBTN.UseVisualStyleBackColor = false;
            this.OdayiEklemeBTN.Click += new System.EventHandler(this.OdayiEklemeBTN_Click);
            // 
            // OdaEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(581, 300);
            this.Controls.Add(this.OdayiEklemeBTN);
            this.Controls.Add(this.BackBTN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OdaKatiBOX);
            this.Controls.Add(this.OdaKapasiteBox);
            this.Controls.Add(this.OdaNumarasiBOX);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "OdaEkleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OdaEkleme";
            ((System.ComponentModel.ISupportInitialize)(this.BackBTN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OdaNumarasiBOX;
        private System.Windows.Forms.TextBox OdaKapasiteBox;
        private System.Windows.Forms.TextBox OdaKatiBOX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox BackBTN;
        private System.Windows.Forms.Button OdayiEklemeBTN;
    }
}