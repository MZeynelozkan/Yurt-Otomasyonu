namespace YeniYurt
{
    partial class GiderSil
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
            this.SilBTN = new System.Windows.Forms.Button();
            this.GiderID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GiderTutar = new System.Windows.Forms.TextBox();
            this.BackBTN = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BackBTN)).BeginInit();
            this.SuspendLayout();
            // 
            // SilBTN
            // 
            this.SilBTN.BackColor = System.Drawing.Color.White;
            this.SilBTN.Location = new System.Drawing.Point(265, 155);
            this.SilBTN.Name = "SilBTN";
            this.SilBTN.Size = new System.Drawing.Size(75, 31);
            this.SilBTN.TabIndex = 34;
            this.SilBTN.Text = "Sil";
            this.SilBTN.UseVisualStyleBackColor = false;
            this.SilBTN.Click += new System.EventHandler(this.SilBTN_Click);
            // 
            // GiderID
            // 
            this.GiderID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GiderID.Location = new System.Drawing.Point(231, 53);
            this.GiderID.Name = "GiderID";
            this.GiderID.Size = new System.Drawing.Size(109, 21);
            this.GiderID.TabIndex = 33;
            this.GiderID.TextChanged += new System.EventHandler(this.GiderID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Gider ID";
            // 
            // GiderTutar
            // 
            this.GiderTutar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GiderTutar.Location = new System.Drawing.Point(231, 100);
            this.GiderTutar.Name = "GiderTutar";
            this.GiderTutar.Size = new System.Drawing.Size(109, 21);
            this.GiderTutar.TabIndex = 35;
            // 
            // BackBTN
            // 
            this.BackBTN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackBTN.Image = global::YeniYurt.Properties.Resources.icons8_logout_rounded_left_50;
            this.BackBTN.Location = new System.Drawing.Point(0, 0);
            this.BackBTN.Name = "BackBTN";
            this.BackBTN.Size = new System.Drawing.Size(47, 48);
            this.BackBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BackBTN.TabIndex = 31;
            this.BackBTN.TabStop = false;
            this.BackBTN.Click += new System.EventHandler(this.BackBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Gider Tutar";
            // 
            // GiderSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(435, 236);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GiderTutar);
            this.Controls.Add(this.SilBTN);
            this.Controls.Add(this.GiderID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GiderSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GiderSil";
            ((System.ComponentModel.ISupportInitialize)(this.BackBTN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BackBTN;
        private System.Windows.Forms.Button SilBTN;
        private System.Windows.Forms.TextBox GiderID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GiderTutar;
        private System.Windows.Forms.Label label2;
    }
}