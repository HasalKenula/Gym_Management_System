namespace Gym_Management_System.pages.admin
{
    partial class WorkoutManegement
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
       
        
        #endregion

        private System.Windows.Forms.Panel pnlWorkoutManegment;

        private System.Windows.Forms.Label lblMemberId;
        private System.Windows.Forms.TextBox txtMemberId;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvWorkoutTable;
        private System.Windows.Forms.Button btnAssignPlan;
        private System.Windows.Forms.Button btnUpdatePlan;
        private System.Windows.Forms.Button btnDeletePlan;
        private System.Windows.Forms.Label lblMessage;


        private void InitializeComponent()
        {
            this.pnlWorkoutManegment = new System.Windows.Forms.Panel();
            this.lblMemberId = new System.Windows.Forms.Label();
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.dgvWorkoutTable = new System.Windows.Forms.DataGridView();
            this.btnAssignPlan = new System.Windows.Forms.Button();
            this.btnUpdatePlan = new System.Windows.Forms.Button();
            this.btnDeletePlan = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlWorkoutManegment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkoutTable)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlWorkoutManegment
            // 
            this.pnlWorkoutManegment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlWorkoutManegment.Controls.Add(this.lblMemberId);
            this.pnlWorkoutManegment.Controls.Add(this.txtMemberId);
            this.pnlWorkoutManegment.Controls.Add(this.btnSearch);
            this.pnlWorkoutManegment.Controls.Add(this.lblMessage);
            this.pnlWorkoutManegment.Controls.Add(this.dgvWorkoutTable);
            this.pnlWorkoutManegment.Controls.Add(this.btnAssignPlan);
            this.pnlWorkoutManegment.Controls.Add(this.btnUpdatePlan);
            this.pnlWorkoutManegment.Controls.Add(this.btnDeletePlan);
            this.pnlWorkoutManegment.Location = new System.Drawing.Point(20, 20);
            this.pnlWorkoutManegment.Name = "pnlWorkoutManegment";
            this.pnlWorkoutManegment.Size = new System.Drawing.Size(1031, 532);
            this.pnlWorkoutManegment.TabIndex = 0;
            this.pnlWorkoutManegment.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlWorkoutManegment_Paint);
            // 
            // lblMemberId
            // 
            this.lblMemberId.AutoSize = true;
            this.lblMemberId.Location = new System.Drawing.Point(30, 27);
            this.lblMemberId.Name = "lblMemberId";
            this.lblMemberId.Size = new System.Drawing.Size(73, 16);
            this.lblMemberId.TabIndex = 0;
            this.lblMemberId.Text = "Member ID";
            // 
            // txtMemberId
            // 
            this.txtMemberId.Location = new System.Drawing.Point(120, 27);
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.Size = new System.Drawing.Size(180, 22);
            this.txtMemberId.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(320, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 27);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.Green;
            this.lblMessage.Location = new System.Drawing.Point(30, 60);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 16);
            this.lblMessage.TabIndex = 3;
            // 
            // dgvWorkoutTable
            // 
            this.dgvWorkoutTable.AllowUserToAddRows = false;
            this.dgvWorkoutTable.AllowUserToDeleteRows = false;
            this.dgvWorkoutTable.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvWorkoutTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkoutTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvWorkoutTable.Location = new System.Drawing.Point(30, 90);
            this.dgvWorkoutTable.Name = "dgvWorkoutTable";
            this.dgvWorkoutTable.RowHeadersWidth = 51;
            this.dgvWorkoutTable.Size = new System.Drawing.Size(555, 285);
            this.dgvWorkoutTable.TabIndex = 4;
            this.dgvWorkoutTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWorkoutTable_CellContentClick);
            // 
            // btnAssignPlan
            // 
            this.btnAssignPlan.Location = new System.Drawing.Point(33, 423);
            this.btnAssignPlan.Name = "btnAssignPlan";
            this.btnAssignPlan.Size = new System.Drawing.Size(110, 30);
            this.btnAssignPlan.TabIndex = 5;
            this.btnAssignPlan.Text = "Assign Plan";
            this.btnAssignPlan.Click += new System.EventHandler(this.btnAssignPlan_Click);
            // 
            // btnUpdatePlan
            // 
            this.btnUpdatePlan.Location = new System.Drawing.Point(164, 423);
            this.btnUpdatePlan.Name = "btnUpdatePlan";
            this.btnUpdatePlan.Size = new System.Drawing.Size(110, 30);
            this.btnUpdatePlan.TabIndex = 6;
            this.btnUpdatePlan.Text = "Update Plan";
            this.btnUpdatePlan.Click += new System.EventHandler(this.btnUpdatePlan_Click);
            // 
            // btnDeletePlan
            // 
            this.btnDeletePlan.Location = new System.Drawing.Point(300, 423);
            this.btnDeletePlan.Name = "btnDeletePlan";
            this.btnDeletePlan.Size = new System.Drawing.Size(110, 30);
            this.btnDeletePlan.TabIndex = 7;
            this.btnDeletePlan.Text = "Delete Plan";
            this.btnDeletePlan.Click += new System.EventHandler(this.btnDeletePlan_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Day";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Workout";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Reps";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Trainer Name";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // WorkoutManegement
            // 
            this.ClientSize = new System.Drawing.Size(1097, 578);
            this.Controls.Add(this.pnlWorkoutManegment);
            this.Name = "WorkoutManegement";
            this.Text = "Assign Workout Plan";
            this.pnlWorkoutManegment.ResumeLayout(false);
            this.pnlWorkoutManegment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkoutTable)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}