namespace YeniYurt
{
    partial class GelirGider
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GelirBtn = new System.Windows.Forms.Button();
            this.GiderBtn = new System.Windows.Forms.Button();
            this.ToplamNetGelirGiderBTN = new System.Windows.Forms.Button();
            this.BackBTN = new System.Windows.Forms.PictureBox();
            this.GiderSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackBTN)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(78, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(460, 236);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // GelirBtn
            // 
            this.GelirBtn.BackColor = System.Drawing.Color.White;
            this.GelirBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GelirBtn.Location = new System.Drawing.Point(572, 87);
            this.GelirBtn.Name = "GelirBtn";
            this.GelirBtn.Size = new System.Drawing.Size(128, 50);
            this.GelirBtn.TabIndex = 27;
            this.GelirBtn.Text = "Gelirleri Goster";
            this.GelirBtn.UseVisualStyleBackColor = false;
            this.GelirBtn.Click += new System.EventHandler(this.GelirBtn_Click);
            // 
            // GiderBtn
            // 
            this.GiderBtn.BackColor = System.Drawing.Color.White;
            this.GiderBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GiderBtn.Location = new System.Drawing.Point(572, 180);
            this.GiderBtn.Name = "GiderBtn";
            this.GiderBtn.Size = new System.Drawing.Size(128, 50);
            this.GiderBtn.TabIndex = 28;
            this.GiderBtn.Text = "Giderleri Goster";
            this.GiderBtn.UseVisualStyleBackColor = false;
            this.GiderBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ToplamNetGelirGiderBTN
            // 
            this.ToplamNetGelirGiderBTN.BackColor = System.Drawing.Color.White;
            this.ToplamNetGelirGiderBTN.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToplamNetGelirGiderBTN.Location = new System.Drawing.Point(572, 273);
            this.ToplamNetGelirGiderBTN.Name = "ToplamNetGelirGiderBTN";
            this.ToplamNetGelirGiderBTN.Size = new System.Drawing.Size(128, 50);
            this.ToplamNetGelirGiderBTN.TabIndex = 29;
            this.ToplamNetGelirGiderBTN.Text = "NET Gelir Gider";
            this.ToplamNetGelirGiderBTN.UseVisualStyleBackColor = false;
            this.ToplamNetGelirGiderBTN.Click += new System.EventHandler(this.ToplamNetGelirGiderBTN_Click);
            // 
            // BackBTN
            // 
            this.BackBTN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackBTN.Image = global::YeniYurt.Properties.Resources.icons8_logout_rounded_left_50;
            this.BackBTN.Location = new System.Drawing.Point(0, 0);
            this.BackBTN.Name = "BackBTN";
            this.BackBTN.Size = new System.Drawing.Size(47, 48);
            this.BackBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BackBTN.TabIndex = 30;
            this.BackBTN.TabStop = false;
            this.BackBTN.Click += new System.EventHandler(this.BackBTN_Click);
            // 
            // GiderSil
            // 
            this.GiderSil.BackColor = System.Drawing.Color.White;
            this.GiderSil.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GiderSil.Location = new System.Drawing.Point(265, 338);
            this.GiderSil.Name = "GiderSil";
            this.GiderSil.Size = new System.Drawing.Size(128, 62);
            this.GiderSil.TabIndex = 32;
            this.GiderSil.Text = "Gider Tablosundan Veri Sil";
            this.GiderSil.UseVisualStyleBackColor = false;
            this.GiderSil.Click += new System.EventHandler(this.GiderSil_Click);
            // 
            // GelirGider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(759, 423);
            this.Controls.Add(this.GiderSil);
            this.Controls.Add(this.BackBTN);
            this.Controls.Add(this.ToplamNetGelirGiderBTN);
            this.Controls.Add(this.GiderBtn);
            this.Controls.Add(this.GelirBtn);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "GelirGider";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GelirGider";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackBTN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button GelirBtn;
        private System.Windows.Forms.Button GiderBtn;
        private System.Windows.Forms.Button ToplamNetGelirGiderBTN;
        private System.Windows.Forms.PictureBox BackBTN;
        private System.Windows.Forms.Button GiderSil;
    }
}