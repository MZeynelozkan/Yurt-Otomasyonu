namespace YeniYurt
{
    partial class OgrenciSilmeForm
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
            this.OgrenciID = new System.Windows.Forms.TextBox();
            this.SilBTN = new System.Windows.Forms.Button();
            this.BackBTN = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BackBTN)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ogrenci ID";
            // 
            // OgrenciID
            // 
            this.OgrenciID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OgrenciID.Location = new System.Drawing.Point(159, 48);
            this.OgrenciID.Name = "OgrenciID";
            this.OgrenciID.Size = new System.Drawing.Size(109, 21);
            this.OgrenciID.TabIndex = 1;
            // 
            // SilBTN
            // 
            this.SilBTN.BackColor = System.Drawing.Color.White;
            this.SilBTN.Location = new System.Drawing.Point(193, 98);
            this.SilBTN.Name = "SilBTN";
            this.SilBTN.Size = new System.Drawing.Size(75, 23);
            this.SilBTN.TabIndex = 2;
            this.SilBTN.Text = "Sil";
            this.SilBTN.UseVisualStyleBackColor = false;
            this.SilBTN.Click += new System.EventHandler(this.SilBTN_Click);
            // 
            // BackBTN
            // 
            this.BackBTN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackBTN.Image = global::YeniYurt.Properties.Resources.icons8_logout_rounded_left_50;
            this.BackBTN.Location = new System.Drawing.Point(-1, -2);
            this.BackBTN.Name = "BackBTN";
            this.BackBTN.Size = new System.Drawing.Size(43, 36);
            this.BackBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackBTN.TabIndex = 21;
            this.BackBTN.TabStop = false;
            this.BackBTN.Click += new System.EventHandler(this.BackBTN_Click);
            // 
            // OgrenciSilmeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(298, 159);
            this.Controls.Add(this.BackBTN);
            this.Controls.Add(this.SilBTN);
            this.Controls.Add(this.OgrenciID);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "OgrenciSilmeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OgrenciSilmeForm";
            ((System.ComponentModel.ISupportInitialize)(this.BackBTN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OgrenciID;
        private System.Windows.Forms.Button SilBTN;
        private System.Windows.Forms.PictureBox BackBTN;
    }
}