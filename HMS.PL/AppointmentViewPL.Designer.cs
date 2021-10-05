
namespace HMS.PL
{
    partial class AppointmentViewPL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentViewPL));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddAppoiment = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvAppointmentReport = new System.Windows.Forms.DataGridView();
            this.Edite = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Approved = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DELETE = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointmentReport)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Appointments Module";
            // 
            // btnAddAppoiment
            // 
            this.btnAddAppoiment.FlatAppearance.BorderSize = 0;
            this.btnAddAppoiment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAppoiment.Image = global::HMS.PL.Properties.Resources.icons8_add_new_30;
            this.btnAddAppoiment.Location = new System.Drawing.Point(19, 47);
            this.btnAddAppoiment.Name = "btnAddAppoiment";
            this.btnAddAppoiment.Size = new System.Drawing.Size(31, 32);
            this.btnAddAppoiment.TabIndex = 11;
            this.btnAddAppoiment.UseVisualStyleBackColor = true;
            this.btnAddAppoiment.Click += new System.EventHandler(this.btnAddAppoiment_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1222, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(41, 35);
            this.btnExit.TabIndex = 10;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgvAppointmentReport
            // 
            this.dgvAppointmentReport.AllowUserToAddRows = false;
            this.dgvAppointmentReport.AllowUserToDeleteRows = false;
            this.dgvAppointmentReport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dgvAppointmentReport.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppointmentReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAppointmentReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointmentReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edite,
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column6,
            this.Approved,
            this.DELETE,
            this.Column4});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAppointmentReport.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvAppointmentReport.Location = new System.Drawing.Point(19, 85);
            this.dgvAppointmentReport.MultiSelect = false;
            this.dgvAppointmentReport.Name = "dgvAppointmentReport";
            this.dgvAppointmentReport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppointmentReport.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvAppointmentReport.RowHeadersVisible = false;
            this.dgvAppointmentReport.RowHeadersWidth = 50;
            this.dgvAppointmentReport.Size = new System.Drawing.Size(1229, 398);
            this.dgvAppointmentReport.TabIndex = 19;
            this.dgvAppointmentReport.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAppointmentReport_CellClick);
            this.dgvAppointmentReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAppointmentReport_CellContentClick);
            // 
            // Edite
            // 
            this.Edite.DataPropertyName = "Edite";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edite.DefaultCellStyle = dataGridViewCellStyle2;
            this.Edite.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Edite.Frozen = true;
            this.Edite.HeaderText = "EDITE";
            this.Edite.Name = "Edite";
            this.Edite.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edite.Text = "EDITE";
            this.Edite.ToolTipText = "Edite";
            this.Edite.UseColumnTextForButtonValue = true;
            this.Edite.Width = 80;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "StaffName";
            this.Column5.Frozen = true;
            this.Column5.HeaderText = "Medical Officer";
            this.Column5.Name = "Column5";
            this.Column5.Width = 245;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PatientName";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Patient Name";
            this.Column1.Name = "Column1";
            this.Column1.Width = 245;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Date";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Appointment Date";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Time";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column3.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "Appointment Time";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Status";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column6.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column6.Frozen = true;
            this.Column6.HeaderText = "Status";
            this.Column6.Name = "Column6";
            // 
            // Approved
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.NullValue = false;
            this.Approved.DefaultCellStyle = dataGridViewCellStyle7;
            this.Approved.HeaderText = "Approved";
            this.Approved.Name = "Approved";
            // 
            // DELETE
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DELETE.DefaultCellStyle = dataGridViewCellStyle8;
            this.DELETE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DELETE.HeaderText = "DELETE";
            this.DELETE.Name = "DELETE";
            this.DELETE.Text = "DELETE";
            this.DELETE.ToolTipText = "DELETE";
            this.DELETE.UseColumnTextForButtonValue = true;
            this.DELETE.Width = 80;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "AppoitmentId";
            this.Column4.HeaderText = "Id";
            this.Column4.Name = "Column4";
            this.Column4.Visible = false;
            // 
            // AppointmentViewPL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1266, 506);
            this.Controls.Add(this.dgvAppointmentReport);
            this.Controls.Add(this.btnAddAppoiment);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AppointmentViewPL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppointmentViewPL";
            this.Load += new System.EventHandler(this.AppointmentViewPL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointmentReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddAppoiment;
        private System.Windows.Forms.DataGridView dgvAppointmentReport;
        private System.Windows.Forms.DataGridViewButtonColumn Edite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Approved;
        private System.Windows.Forms.DataGridViewButtonColumn DELETE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}