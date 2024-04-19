namespace YeniYurt
{
    partial class OgrenciForm
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
            this.OgrenciIDLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.KayitLabel = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.PassBOX = new System.Windows.Forms.TextBox();
            this.GirisBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OgrenciIDLabel
            // 
            this.OgrenciIDLabel.AutoSize = true;
            this.OgrenciIDLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OgrenciIDLabel.Location = new System.Drawing.Point(78, 148);
            this.OgrenciIDLabel.Name = "OgrenciIDLabel";
            this.OgrenciIDLabel.Size = new System.Drawing.Size(73, 15);
            this.OgrenciIDLabel.TabIndex = 0;
            this.OgrenciIDLabel.Text = "OgrenciID";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(80, 227);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(71, 15);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "Password";
            // 
            // KayitLabel
            // 
            this.KayitLabel.AutoSize = true;
            this.KayitLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KayitLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.KayitLabel.Location = new System.Drawing.Point(127, 367);
            this.KayitLabel.Name = "KayitLabel";
            this.KayitLabel.Size = new System.Drawing.Size(124, 28);
            this.KayitLabel.TabIndex = 2;
            this.KayitLabel.Text = "KAYIT OL";
            this.KayitLabel.Click += new System.EventHandler(this.KayitLabel_Click);
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(169, 143);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(126, 20);
            this.IDBox.TabIndex = 3;
            this.IDBox.TextChanged += new System.EventHandler(this.IDBox_TextChanged);
            // 
            // PassBOX
            // 
            this.PassBOX.Location = new System.Drawing.Point(169, 222);
            this.PassBOX.Name = "PassBOX";
            this.PassBOX.Size = new System.Drawing.Size(126, 20);
            this.PassBOX.TabIndex = 4;
            this.PassBOX.TextChanged += new System.EventHandler(this.PassBOX_TextChanged);
            // 
            // GirisBTN
            // 
            this.GirisBTN.Location = new System.Drawing.Point(216, 287);
            this.GirisBTN.Name = "GirisBTN";
            this.GirisBTN.Size = new System.Drawing.Size(79, 31);
            this.GirisBTN.TabIndex = 5;
            this.GirisBTN.Text = "GIRIS";
            this.GirisBTN.UseVisualStyleBackColor = true;
            this.GirisBTN.Click += new System.EventHandler(this.GirisBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(79, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "YURT OTOMASYONU";
            // 
            // OgrenciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 415);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GirisBTN);
            this.Controls.Add(this.PassBOX);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.KayitLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.OgrenciIDLabel);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "OgrenciForm";
            this.Text = "OgrenciForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OgrenciIDLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label KayitLabel;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.TextBox PassBOX;
        private System.Windows.Forms.Button GirisBTN;
        private System.Windows.Forms.Label label1;
    }
}