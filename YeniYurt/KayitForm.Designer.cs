namespace YeniYurt
{
    partial class KayitForm
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
            this.OgrenciIDLabel = new System.Windows.Forms.Label();
            this.AdLabel = new System.Windows.Forms.Label();
            this.SoyisimLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DogumTarihiPick = new System.Windows.Forms.DateTimePicker();
            this.IsimBox = new System.Windows.Forms.TextBox();
            this.SoyIsimBox = new System.Windows.Forms.TextBox();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.KayitOLBtn = new System.Windows.Forms.Button();
            this.BackBTN = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.BackBTN)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(222, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "YURT OTOMASYONU";
            // 
            // OgrenciIDLabel
            // 
            this.OgrenciIDLabel.AutoSize = true;
            this.OgrenciIDLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OgrenciIDLabel.Location = new System.Drawing.Point(180, 259);
            this.OgrenciIDLabel.Name = "OgrenciIDLabel";
            this.OgrenciIDLabel.Size = new System.Drawing.Size(83, 17);
            this.OgrenciIDLabel.TabIndex = 7;
            this.OgrenciIDLabel.Text = "OgrenciID";
            // 
            // AdLabel
            // 
            this.AdLabel.AutoSize = true;
            this.AdLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdLabel.Location = new System.Drawing.Point(180, 124);
            this.AdLabel.Name = "AdLabel";
            this.AdLabel.Size = new System.Drawing.Size(38, 17);
            this.AdLabel.TabIndex = 9;
            this.AdLabel.Text = "Isim";
            // 
            // SoyisimLabel
            // 
            this.SoyisimLabel.AutoSize = true;
            this.SoyisimLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoyisimLabel.Location = new System.Drawing.Point(180, 168);
            this.SoyisimLabel.Name = "SoyisimLabel";
            this.SoyisimLabel.Size = new System.Drawing.Size(69, 17);
            this.SoyisimLabel.TabIndex = 10;
            this.SoyisimLabel.Text = "Soy Isim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(180, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Dogum Tarihi";
            // 
            // DogumTarihiPick
            // 
            this.DogumTarihiPick.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DogumTarihiPick.Location = new System.Drawing.Point(311, 197);
            this.DogumTarihiPick.Name = "DogumTarihiPick";
            this.DogumTarihiPick.Size = new System.Drawing.Size(204, 23);
            this.DogumTarihiPick.TabIndex = 13;
            this.DogumTarihiPick.ValueChanged += new System.EventHandler(this.DogumTarihiPick_ValueChanged);
            // 
            // IsimBox
            // 
            this.IsimBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsimBox.Location = new System.Drawing.Point(311, 118);
            this.IsimBox.Name = "IsimBox";
            this.IsimBox.Size = new System.Drawing.Size(204, 23);
            this.IsimBox.TabIndex = 14;
            this.IsimBox.TextChanged += new System.EventHandler(this.IsimBox_TextChanged);
            // 
            // SoyIsimBox
            // 
            this.SoyIsimBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoyIsimBox.Location = new System.Drawing.Point(311, 162);
            this.SoyIsimBox.Name = "SoyIsimBox";
            this.SoyIsimBox.Size = new System.Drawing.Size(204, 23);
            this.SoyIsimBox.TabIndex = 15;
            this.SoyIsimBox.TextChanged += new System.EventHandler(this.SoyIsimBox_TextChanged);
            // 
            // IDBox
            // 
            this.IDBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDBox.Location = new System.Drawing.Point(311, 253);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(204, 23);
            this.IDBox.TabIndex = 16;
            this.IDBox.TextChanged += new System.EventHandler(this.IDBox_TextChanged);
            // 
            // KayitOLBtn
            // 
            this.KayitOLBtn.BackColor = System.Drawing.Color.White;
            this.KayitOLBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KayitOLBtn.Location = new System.Drawing.Point(349, 324);
            this.KayitOLBtn.Name = "KayitOLBtn";
            this.KayitOLBtn.Size = new System.Drawing.Size(182, 51);
            this.KayitOLBtn.TabIndex = 18;
            this.KayitOLBtn.Text = "KAYDET";
            this.KayitOLBtn.UseVisualStyleBackColor = false;
            this.KayitOLBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // BackBTN
            // 
            this.BackBTN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackBTN.Image = global::YeniYurt.Properties.Resources.icons8_logout_rounded_left_50;
            this.BackBTN.Location = new System.Drawing.Point(-1, 0);
            this.BackBTN.Name = "BackBTN";
            this.BackBTN.Size = new System.Drawing.Size(47, 48);
            this.BackBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BackBTN.TabIndex = 19;
            this.BackBTN.TabStop = false;
            this.BackBTN.Click += new System.EventHandler(this.BackBTN_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(365, 418);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(166, 38);
            this.progressBar1.TabIndex = 20;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            // 
            // KayitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(667, 585);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.BackBTN);
            this.Controls.Add(this.KayitOLBtn);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.SoyIsimBox);
            this.Controls.Add(this.IsimBox);
            this.Controls.Add(this.DogumTarihiPick);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SoyisimLabel);
            this.Controls.Add(this.AdLabel);
            this.Controls.Add(this.OgrenciIDLabel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "KayitForm";
            this.Text = "KayitForm";
            this.Load += new System.EventHandler(this.KayitForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BackBTN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label OgrenciIDLabel;
        private System.Windows.Forms.Label AdLabel;
        private System.Windows.Forms.Label SoyisimLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DogumTarihiPick;
        private System.Windows.Forms.TextBox IsimBox;
        private System.Windows.Forms.TextBox SoyIsimBox;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.Button KayitOLBtn;
        private System.Windows.Forms.PictureBox BackBTN;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}