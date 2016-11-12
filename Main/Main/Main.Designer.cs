namespace Main
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pbBackgroundImage = new System.Windows.Forms.PictureBox();
            this.lTitle = new System.Windows.Forms.Label();
            this.btnBoost = new System.Windows.Forms.Button();
            this.btnLockUnlock = new System.Windows.Forms.Button();
            this.btnSelectDir = new System.Windows.Forms.Button();
            this.cbProfiles = new System.Windows.Forms.ComboBox();
            this.lSelectProfile = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackgroundImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBackgroundImage
            // 
            this.pbBackgroundImage.Image = global::Arma_Booster.Properties.Resources.arma3soldier1;
            this.pbBackgroundImage.Location = new System.Drawing.Point(-21, 1);
            this.pbBackgroundImage.Name = "pbBackgroundImage";
            this.pbBackgroundImage.Size = new System.Drawing.Size(530, 153);
            this.pbBackgroundImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBackgroundImage.TabIndex = 1;
            this.pbBackgroundImage.TabStop = false;
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.Location = new System.Drawing.Point(78, 13);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(258, 32);
            this.lTitle.TabIndex = 4;
            this.lTitle.Text = "Arma III Booster - v2.1";
            // 
            // btnBoost
            // 
            this.btnBoost.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnBoost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBoost.Location = new System.Drawing.Point(114, 102);
            this.btnBoost.Name = "btnBoost";
            this.btnBoost.Size = new System.Drawing.Size(99, 37);
            this.btnBoost.TabIndex = 5;
            this.btnBoost.TabStop = false;
            this.btnBoost.Text = "Boost";
            this.btnBoost.UseVisualStyleBackColor = false;
            this.btnBoost.Click += new System.EventHandler(this.btnBoost_Click);
            // 
            // btnLockUnlock
            // 
            this.btnLockUnlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLockUnlock.Location = new System.Drawing.Point(219, 102);
            this.btnLockUnlock.Name = "btnLockUnlock";
            this.btnLockUnlock.Size = new System.Drawing.Size(117, 37);
            this.btnLockUnlock.TabIndex = 6;
            this.btnLockUnlock.TabStop = false;
            this.btnLockUnlock.Text = "Lock configuration";
            this.btnLockUnlock.UseVisualStyleBackColor = true;
            this.btnLockUnlock.Click += new System.EventHandler(this.btnLockUnlock_Click);
            // 
            // btnSelectDir
            // 
            this.btnSelectDir.Location = new System.Drawing.Point(303, 64);
            this.btnSelectDir.Name = "btnSelectDir";
            this.btnSelectDir.Size = new System.Drawing.Size(29, 21);
            this.btnSelectDir.TabIndex = 8;
            this.btnSelectDir.TabStop = false;
            this.btnSelectDir.Text = "...";
            this.btnSelectDir.UseVisualStyleBackColor = true;
            this.btnSelectDir.Click += new System.EventHandler(this.btnSelectDir_Click);
            // 
            // cbProfiles
            // 
            this.cbProfiles.DropDownHeight = 40;
            this.cbProfiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProfiles.FormattingEnabled = true;
            this.cbProfiles.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbProfiles.IntegralHeight = false;
            this.cbProfiles.Location = new System.Drawing.Point(114, 64);
            this.cbProfiles.Name = "cbProfiles";
            this.cbProfiles.Size = new System.Drawing.Size(183, 21);
            this.cbProfiles.TabIndex = 9;
            this.cbProfiles.TabStop = false;
            // 
            // lSelectProfile
            // 
            this.lSelectProfile.AutoSize = true;
            this.lSelectProfile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSelectProfile.Location = new System.Drawing.Point(111, 45);
            this.lSelectProfile.Name = "lSelectProfile";
            this.lSelectProfile.Size = new System.Drawing.Size(105, 15);
            this.lSelectProfile.TabIndex = 10;
            this.lSelectProfile.Text = "Select your Profile:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(348, 151);
            this.Controls.Add(this.lSelectProfile);
            this.Controls.Add(this.cbProfiles);
            this.Controls.Add(this.btnSelectDir);
            this.Controls.Add(this.btnBoost);
            this.Controls.Add(this.btnLockUnlock);
            this.Controls.Add(this.lTitle);
            this.Controls.Add(this.pbBackgroundImage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arma Booster";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pbBackgroundImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBackgroundImage;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Button btnBoost;
        private System.Windows.Forms.Button btnLockUnlock;
        private System.Windows.Forms.Button btnSelectDir;
        private System.Windows.Forms.Label lSelectProfile;
        private System.Windows.Forms.ComboBox cbProfiles;
    }
}

