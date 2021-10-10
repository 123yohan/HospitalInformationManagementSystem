
namespace HMS.PL
{
    partial class MasterForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_time = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LBL_DATE = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnUserLog = new System.Windows.Forms.FlowLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnPatient = new System.Windows.Forms.Button();
            this.btnVisitors = new System.Windows.Forms.Button();
            this.btnComplatine = new System.Windows.Forms.Button();
            this.bnappointment = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnAppointmentReport = new System.Windows.Forms.Button();
            this.btnDletedAppointment = new System.Windows.Forms.Button();
            this.btnPc = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPostal = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.btnUserLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.btn_logout);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1162, 70);
            this.panel1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(1061, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Admin";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(995, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Welcome Yohan";
            // 
            // label2
            // 
            this.label2.Image = global::HMS.PL.Properties.Resources.icons8_hospital_3_45;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 34);
            this.label2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(59, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hospital Information Management System";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1109, 18);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(41, 35);
            this.btnExit.TabIndex = 1;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel4.Controls.Add(this.lbl_time);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.LBL_DATE);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 537);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1162, 22);
            this.panel4.TabIndex = 8;
            // 
            // lbl_time
            // 
            this.lbl_time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_time.AutoSize = true;
            this.lbl_time.BackColor = System.Drawing.SystemColors.Highlight;
            this.lbl_time.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_time.Location = new System.Drawing.Point(1098, 5);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(28, 14);
            this.lbl_time.TabIndex = 8;
            this.lbl_time.Text = "N/A";
            this.lbl_time.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(999, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 14);
            this.label8.TabIndex = 7;
            this.label8.Text = "SYSTEM TIME :";
            // 
            // LBL_DATE
            // 
            this.LBL_DATE.AutoSize = true;
            this.LBL_DATE.BackColor = System.Drawing.SystemColors.Highlight;
            this.LBL_DATE.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DATE.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LBL_DATE.Location = new System.Drawing.Point(107, 4);
            this.LBL_DATE.Name = "LBL_DATE";
            this.LBL_DATE.Size = new System.Drawing.Size(28, 14);
            this.LBL_DATE.TabIndex = 6;
            this.LBL_DATE.Text = "N/A";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(406, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Copyright © 2020, Uovt. All Rights Reserved";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "SYSTEM DATE :";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnUserLog
            // 
            this.btnUserLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnUserLog.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnUserLog.Controls.Add(this.button2);
            this.btnUserLog.Controls.Add(this.btnPatient);
            this.btnUserLog.Controls.Add(this.btnVisitors);
            this.btnUserLog.Controls.Add(this.btnComplatine);
            this.btnUserLog.Controls.Add(this.bnappointment);
            this.btnUserLog.Controls.Add(this.button3);
            this.btnUserLog.Controls.Add(this.btnAppointmentReport);
            this.btnUserLog.Controls.Add(this.btnDletedAppointment);
            this.btnUserLog.Controls.Add(this.btnPc);
            this.btnUserLog.Controls.Add(this.button1);
            this.btnUserLog.Controls.Add(this.btnPostal);
            this.btnUserLog.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUserLog.Location = new System.Drawing.Point(0, 70);
            this.btnUserLog.Name = "btnUserLog";
            this.btnUserLog.Size = new System.Drawing.Size(1162, 113);
            this.btnUserLog.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.Image = global::HMS.PL.Properties.Resources.icons8_business_building_40;
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 96);
            this.button2.TabIndex = 10;
            this.button2.Text = "STAFF";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPatient
            // 
            this.btnPatient.FlatAppearance.BorderSize = 0;
            this.btnPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatient.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPatient.Image = global::HMS.PL.Properties.Resources.icons8_handicapped_40;
            this.btnPatient.Location = new System.Drawing.Point(97, 3);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.Size = new System.Drawing.Size(88, 96);
            this.btnPatient.TabIndex = 10;
            this.btnPatient.Text = "PATIENT";
            this.btnPatient.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPatient.UseVisualStyleBackColor = true;
            this.btnPatient.Visible = false;
            this.btnPatient.Click += new System.EventHandler(this.btnPatient_Click);
            // 
            // btnVisitors
            // 
            this.btnVisitors.FlatAppearance.BorderSize = 0;
            this.btnVisitors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisitors.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisitors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnVisitors.Image = global::HMS.PL.Properties.Resources.icons8_tourist_guide_skin_type_1_30;
            this.btnVisitors.Location = new System.Drawing.Point(191, 3);
            this.btnVisitors.Name = "btnVisitors";
            this.btnVisitors.Size = new System.Drawing.Size(88, 96);
            this.btnVisitors.TabIndex = 10;
            this.btnVisitors.Text = "VISITORS";
            this.btnVisitors.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVisitors.UseVisualStyleBackColor = true;
            this.btnVisitors.Visible = false;
            this.btnVisitors.Click += new System.EventHandler(this.btnVisitors_Click);
            // 
            // btnComplatine
            // 
            this.btnComplatine.FlatAppearance.BorderSize = 0;
            this.btnComplatine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComplatine.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplatine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnComplatine.Image = global::HMS.PL.Properties.Resources.icons8_why_quest_40;
            this.btnComplatine.Location = new System.Drawing.Point(285, 3);
            this.btnComplatine.Name = "btnComplatine";
            this.btnComplatine.Size = new System.Drawing.Size(88, 96);
            this.btnComplatine.TabIndex = 10;
            this.btnComplatine.Text = "COMPLATINE";
            this.btnComplatine.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnComplatine.UseVisualStyleBackColor = true;
            this.btnComplatine.Visible = false;
            this.btnComplatine.Click += new System.EventHandler(this.btnComplatine_Click);
            // 
            // bnappointment
            // 
            this.bnappointment.FlatAppearance.BorderSize = 0;
            this.bnappointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnappointment.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnappointment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bnappointment.Image = global::HMS.PL.Properties.Resources.icons8_calendar_plus_40;
            this.bnappointment.Location = new System.Drawing.Point(379, 3);
            this.bnappointment.Name = "bnappointment";
            this.bnappointment.Size = new System.Drawing.Size(88, 98);
            this.bnappointment.TabIndex = 10;
            this.bnappointment.Text = "APPOINTMENT";
            this.bnappointment.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bnappointment.UseVisualStyleBackColor = true;
            this.bnappointment.Visible = false;
            this.bnappointment.Click += new System.EventHandler(this.bnappointment_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.Image = global::HMS.PL.Properties.Resources.icons8_microsoft_to_do_app_30;
            this.button3.Location = new System.Drawing.Point(473, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 98);
            this.button3.TabIndex = 11;
            this.button3.Text = "APPROVED APPOINTMENT";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAppointmentReport
            // 
            this.btnAppointmentReport.FlatAppearance.BorderSize = 0;
            this.btnAppointmentReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppointmentReport.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppointmentReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAppointmentReport.Image = global::HMS.PL.Properties.Resources.icons8_report_card_40;
            this.btnAppointmentReport.Location = new System.Drawing.Point(567, 3);
            this.btnAppointmentReport.Name = "btnAppointmentReport";
            this.btnAppointmentReport.Size = new System.Drawing.Size(88, 98);
            this.btnAppointmentReport.TabIndex = 10;
            this.btnAppointmentReport.Text = "APPOINTMENTT REPORT";
            this.btnAppointmentReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAppointmentReport.UseVisualStyleBackColor = true;
            this.btnAppointmentReport.Visible = false;
            this.btnAppointmentReport.Click += new System.EventHandler(this.btnAppointmentReport_Click);
            // 
            // btnDletedAppointment
            // 
            this.btnDletedAppointment.FlatAppearance.BorderSize = 0;
            this.btnDletedAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDletedAppointment.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDletedAppointment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDletedAppointment.Image = global::HMS.PL.Properties.Resources.icons8_delete_user_data_30;
            this.btnDletedAppointment.Location = new System.Drawing.Point(661, 3);
            this.btnDletedAppointment.Name = "btnDletedAppointment";
            this.btnDletedAppointment.Size = new System.Drawing.Size(88, 96);
            this.btnDletedAppointment.TabIndex = 10;
            this.btnDletedAppointment.Text = "DELETED APPOINTMENT";
            this.btnDletedAppointment.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDletedAppointment.UseVisualStyleBackColor = true;
            this.btnDletedAppointment.Visible = false;
            this.btnDletedAppointment.Click += new System.EventHandler(this.btnDletedAppointment_Click);
            // 
            // btnPc
            // 
            this.btnPc.FlatAppearance.BorderSize = 0;
            this.btnPc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPc.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPc.Image = global::HMS.PL.Properties.Resources.icons8_keep_locked_40;
            this.btnPc.Location = new System.Drawing.Point(755, 3);
            this.btnPc.Name = "btnPc";
            this.btnPc.Size = new System.Drawing.Size(88, 96);
            this.btnPc.TabIndex = 10;
            this.btnPc.Text = "PAGE CONFIG";
            this.btnPc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPc.UseVisualStyleBackColor = true;
            this.btnPc.Visible = false;
            this.btnPc.Click += new System.EventHandler(this.btnPc_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Image = global::HMS.PL.Properties.Resources.icons8_presentation_30;
            this.button1.Location = new System.Drawing.Point(849, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 96);
            this.button1.TabIndex = 10;
            this.button1.Text = "USER LOG REPORT";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnPostal
            // 
            this.btnPostal.FlatAppearance.BorderSize = 0;
            this.btnPostal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPostal.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPostal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPostal.Image = ((System.Drawing.Image)(resources.GetObject("btnPostal.Image")));
            this.btnPostal.Location = new System.Drawing.Point(943, 3);
            this.btnPostal.Name = "btnPostal";
            this.btnPostal.Size = new System.Drawing.Size(88, 96);
            this.btnPostal.TabIndex = 10;
            this.btnPostal.Text = "POSTAL";
            this.btnPostal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPostal.UseVisualStyleBackColor = true;
            this.btnPostal.Visible = false;
            this.btnPostal.Click += new System.EventHandler(this.btnPostal_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.Transparent;
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_logout.Image")));
            this.btn_logout.Location = new System.Drawing.Point(945, 18);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(41, 35);
            this.btn_logout.TabIndex = 11;
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.button4_Click);
            // 
            // MasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1162, 559);
            this.Controls.Add(this.btnUserLog);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "MasterForm";
            this.Text = "MasterForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MasterForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.btnUserLog.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LBL_DATE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FlowLayoutPanel btnUserLog;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnPatient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnComplatine;
        private System.Windows.Forms.Button btnPc;
        private System.Windows.Forms.Button bnappointment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAppointmentReport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnDletedAppointment;
        private System.Windows.Forms.Button btnVisitors;
        private System.Windows.Forms.Button btnPostal;
        private System.Windows.Forms.Button btn_logout;
    }
}



