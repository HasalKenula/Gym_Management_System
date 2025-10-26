namespace Gym_Management_System.pages.user
{
    partial class Profile
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
            this.pnlUserProfile = new System.Windows.Forms.Panel();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.cmbBldGrp = new System.Windows.Forms.ComboBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtTrainer = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pbProfilePic = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlUserProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUserProfile
            // 
            this.pnlUserProfile.Controls.Add(this.btnUpload);
            this.pnlUserProfile.Controls.Add(this.btnSave);
            this.pnlUserProfile.Controls.Add(this.btnEdit);
            this.pnlUserProfile.Controls.Add(this.cmbBldGrp);
            this.pnlUserProfile.Controls.Add(this.cmbGender);
            this.pnlUserProfile.Controls.Add(this.txtWeight);
            this.pnlUserProfile.Controls.Add(this.txtTrainer);
            this.pnlUserProfile.Controls.Add(this.txtHeight);
            this.pnlUserProfile.Controls.Add(this.txtAge);
            this.pnlUserProfile.Controls.Add(this.txtContactNo);
            this.pnlUserProfile.Controls.Add(this.txtEmail);
            this.pnlUserProfile.Controls.Add(this.txtUsername);
            this.pnlUserProfile.Controls.Add(this.txtName);
            this.pnlUserProfile.Controls.Add(this.txtUserId);
            this.pnlUserProfile.Controls.Add(this.label12);
            this.pnlUserProfile.Controls.Add(this.label11);
            this.pnlUserProfile.Controls.Add(this.label10);
            this.pnlUserProfile.Controls.Add(this.label9);
            this.pnlUserProfile.Controls.Add(this.label8);
            this.pnlUserProfile.Controls.Add(this.label7);
            this.pnlUserProfile.Controls.Add(this.pbProfilePic);
            this.pnlUserProfile.Controls.Add(this.label6);
            this.pnlUserProfile.Controls.Add(this.label5);
            this.pnlUserProfile.Controls.Add(this.label4);
            this.pnlUserProfile.Controls.Add(this.label3);
            this.pnlUserProfile.Controls.Add(this.label2);
            this.pnlUserProfile.Location = new System.Drawing.Point(0, 0);
            this.pnlUserProfile.Name = "pnlUserProfile";
            this.pnlUserProfile.Size = new System.Drawing.Size(1482, 873);
            this.pnlUserProfile.TabIndex = 1;
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUpload.Enabled = false;
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpload.Location = new System.Drawing.Point(868, 387);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(122, 43);
            this.btnUpload.TabIndex = 32;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(389, 820);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(187, 50);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(136, 820);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(187, 50);
            this.btnEdit.TabIndex = 30;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // cmbBldGrp
            // 
            this.cmbBldGrp.Enabled = false;
            this.cmbBldGrp.FormattingEnabled = true;
            this.cmbBldGrp.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.cmbBldGrp.Location = new System.Drawing.Point(352, 669);
            this.cmbBldGrp.Name = "cmbBldGrp";
            this.cmbBldGrp.Size = new System.Drawing.Size(254, 24);
            this.cmbBldGrp.TabIndex = 29;
            this.cmbBldGrp.Text = "-Not Selected-";
            // 
            // cmbGender
            // 
            this.cmbGender.Enabled = false;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(352, 602);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(254, 24);
            this.cmbGender.TabIndex = 28;
            this.cmbGender.Text = "-Not Selected-";
            // 
            // txtWeight
            // 
            this.txtWeight.Enabled = false;
            this.txtWeight.Location = new System.Drawing.Point(643, 537);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(165, 22);
            this.txtWeight.TabIndex = 27;
            // 
            // txtTrainer
            // 
            this.txtTrainer.Enabled = false;
            this.txtTrainer.Location = new System.Drawing.Point(352, 736);
            this.txtTrainer.Name = "txtTrainer";
            this.txtTrainer.Size = new System.Drawing.Size(254, 22);
            this.txtTrainer.TabIndex = 25;
            // 
            // txtHeight
            // 
            this.txtHeight.Enabled = false;
            this.txtHeight.Location = new System.Drawing.Point(282, 537);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(165, 22);
            this.txtHeight.TabIndex = 24;
            // 
            // txtAge
            // 
            this.txtAge.Enabled = false;
            this.txtAge.Location = new System.Drawing.Point(352, 473);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(254, 22);
            this.txtAge.TabIndex = 23;
            // 
            // txtContactNo
            // 
            this.txtContactNo.Enabled = false;
            this.txtContactNo.Location = new System.Drawing.Point(352, 408);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(254, 22);
            this.txtContactNo.TabIndex = 22;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(352, 337);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(254, 22);
            this.txtEmail.TabIndex = 21;
            // 
            // txtUsername
            // 
            this.txtUsername.Enabled = false;
            this.txtUsername.Location = new System.Drawing.Point(352, 272);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(254, 22);
            this.txtUsername.TabIndex = 20;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(352, 207);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(254, 22);
            this.txtName.TabIndex = 19;
            // 
            // txtUserId
            // 
            this.txtUserId.Enabled = false;
            this.txtUserId.Location = new System.Drawing.Point(352, 132);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(254, 22);
            this.txtUserId.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(141, 726);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 32);
            this.label12.TabIndex = 17;
            this.label12.Text = "Trainer :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(141, 661);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(202, 32);
            this.label11.TabIndex = 16;
            this.label11.Text = "Blood Group :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(141, 595);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 32);
            this.label10.TabIndex = 15;
            this.label10.Text = "Gender :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(493, 527);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 32);
            this.label9.TabIndex = 14;
            this.label9.Text = "Weight :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(141, 527);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 32);
            this.label8.TabIndex = 13;
            this.label8.Text = "Height :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(141, 463);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 32);
            this.label7.TabIndex = 12;
            this.label7.Text = "Age :";
            // 
            // pbProfilePic
            // 
            this.pbProfilePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbProfilePic.Location = new System.Drawing.Point(809, 132);
            this.pbProfilePic.Name = "pbProfilePic";
            this.pbProfilePic.Size = new System.Drawing.Size(234, 227);
            this.pbProfilePic.TabIndex = 6;
            this.pbProfilePic.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(141, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "Contact No :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(141, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "E-mail :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(141, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Username :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(141, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "User Id :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(141, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name :";
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 873);
            this.Controls.Add(this.pnlUserProfile);
            this.Name = "Profile";
            this.Text = "private ";
            this.pnlUserProfile.ResumeLayout(false);
            this.pnlUserProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlUserProfile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pbProfilePic;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtTrainer;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.ComboBox cmbBldGrp;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnUpload;
    }
}