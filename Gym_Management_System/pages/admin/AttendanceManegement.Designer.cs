namespace Gym_Management_System.pages.admin
{
    partial class AttendanceManegement
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
            this.pnlAttendanceManage = new System.Windows.Forms.Panel();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.comboMemberType = new System.Windows.Forms.ComboBox();
            this.textOutDate = new System.Windows.Forms.TextBox();
            this.textInDate = new System.Windows.Forms.TextBox();
            this.textDate = new System.Windows.Forms.TextBox();
            this.textMemberId = new System.Windows.Forms.TextBox();
            this.textId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlAttendanceManage.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAttendanceManage
            // 
            this.pnlAttendanceManage.BackColor = System.Drawing.SystemColors.Control;
            this.pnlAttendanceManage.Controls.Add(this.delete);
            this.pnlAttendanceManage.Controls.Add(this.update);
            this.pnlAttendanceManage.Controls.Add(this.submit);
            this.pnlAttendanceManage.Controls.Add(this.tableLayoutPanel1);
            this.pnlAttendanceManage.Controls.Add(this.comboStatus);
            this.pnlAttendanceManage.Controls.Add(this.comboMemberType);
            this.pnlAttendanceManage.Controls.Add(this.textOutDate);
            this.pnlAttendanceManage.Controls.Add(this.textInDate);
            this.pnlAttendanceManage.Controls.Add(this.textDate);
            this.pnlAttendanceManage.Controls.Add(this.textMemberId);
            this.pnlAttendanceManage.Controls.Add(this.textId);
            this.pnlAttendanceManage.Controls.Add(this.label8);
            this.pnlAttendanceManage.Controls.Add(this.label7);
            this.pnlAttendanceManage.Controls.Add(this.label6);
            this.pnlAttendanceManage.Controls.Add(this.label5);
            this.pnlAttendanceManage.Controls.Add(this.label4);
            this.pnlAttendanceManage.Controls.Add(this.label3);
            this.pnlAttendanceManage.Controls.Add(this.label2);
            this.pnlAttendanceManage.Controls.Add(this.label1);
            this.pnlAttendanceManage.Location = new System.Drawing.Point(-2, -1);
            this.pnlAttendanceManage.Name = "pnlAttendanceManage";
            this.pnlAttendanceManage.Size = new System.Drawing.Size(1501, 888);
            this.pnlAttendanceManage.TabIndex = 0;
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.delete.Location = new System.Drawing.Point(1250, 357);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(166, 50);
            this.delete.TabIndex = 19;
            this.delete.Text = "DELETE";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.update.Location = new System.Drawing.Point(1045, 358);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(166, 50);
            this.update.TabIndex = 18;
            this.update.Text = "UPDATE";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.submit.Location = new System.Drawing.Point(823, 357);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(166, 50);
            this.submit.TabIndex = 17;
            this.submit.Text = "ADD";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click_1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(55, 448);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1399, 226);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // comboStatus
            // 
            this.comboStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Items.AddRange(new object[] {
            "Absent",
            "Present",
            "Late"});
            this.comboStatus.Location = new System.Drawing.Point(1165, 294);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(270, 39);
            this.comboStatus.TabIndex = 15;
            // 
            // comboMemberType
            // 
            this.comboMemberType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMemberType.FormattingEnabled = true;
            this.comboMemberType.Items.AddRange(new object[] {
            "Trainer",
            "Player"});
            this.comboMemberType.Location = new System.Drawing.Point(309, 294);
            this.comboMemberType.Name = "comboMemberType";
            this.comboMemberType.Size = new System.Drawing.Size(270, 39);
            this.comboMemberType.TabIndex = 14;
            // 
            // textOutDate
            // 
            this.textOutDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textOutDate.Location = new System.Drawing.Point(1165, 203);
            this.textOutDate.Name = "textOutDate";
            this.textOutDate.Size = new System.Drawing.Size(274, 38);
            this.textOutDate.TabIndex = 13;
            // 
            // textInDate
            // 
            this.textInDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textInDate.Location = new System.Drawing.Point(1165, 128);
            this.textInDate.Name = "textInDate";
            this.textInDate.Size = new System.Drawing.Size(274, 38);
            this.textInDate.TabIndex = 12;
            // 
            // textDate
            // 
            this.textDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDate.Location = new System.Drawing.Point(306, 370);
            this.textDate.Name = "textDate";
            this.textDate.Size = new System.Drawing.Size(274, 38);
            this.textDate.TabIndex = 11;
            // 
            // textMemberId
            // 
            this.textMemberId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMemberId.Location = new System.Drawing.Point(306, 209);
            this.textMemberId.Name = "textMemberId";
            this.textMemberId.Size = new System.Drawing.Size(274, 38);
            this.textMemberId.TabIndex = 10;
            // 
            // textId
            // 
            this.textId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textId.Location = new System.Drawing.Point(306, 134);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(274, 38);
            this.textId.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(842, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 32);
            this.label8.TabIndex = 7;
            this.label8.Text = "Status";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(842, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(232, 32);
            this.label7.TabIndex = 6;
            this.label7.Text = "Check_out_time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(842, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "Check_in_time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(53, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(53, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Member_type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(53, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Member_id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(53, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Attendance_id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(513, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(539, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Attendence Mangement";
            // 
            // AttendanceManegement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 873);
            this.Controls.Add(this.pnlAttendanceManage);
            this.Name = "AttendanceManegement";
            this.Text = "AttendanceManegement";
            this.pnlAttendanceManage.ResumeLayout(false);
            this.pnlAttendanceManage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAttendanceManage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.TextBox textOutDate;
        private System.Windows.Forms.TextBox textInDate;
        private System.Windows.Forms.TextBox textDate;
        private System.Windows.Forms.TextBox textMemberId;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.ComboBox comboMemberType;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
    }
}