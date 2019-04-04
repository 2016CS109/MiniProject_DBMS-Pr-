namespace ProjectBDb
{
    partial class AttendanceUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StudentAttendanceGroupBox = new System.Windows.Forms.GroupBox();
            this.GetDatabtn = new System.Windows.Forms.Button();
            this.AttendanceStatuscomboBox = new System.Windows.Forms.ComboBox();
            this.AttendanceStatuslbl = new System.Windows.Forms.Label();
            this.StudentAttendancedataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.StudentRollNocombobox = new System.Windows.Forms.ComboBox();
            this.StudentRollNolbl = new System.Windows.Forms.Label();
            this.ClassAttendanceDatelbl = new System.Windows.Forms.Label();
            this.ClassAttendanceDatedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.StudentAttendanceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentAttendancedataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentAttendanceGroupBox
            // 
            this.StudentAttendanceGroupBox.Controls.Add(this.GetDatabtn);
            this.StudentAttendanceGroupBox.Controls.Add(this.AttendanceStatuscomboBox);
            this.StudentAttendanceGroupBox.Controls.Add(this.AttendanceStatuslbl);
            this.StudentAttendanceGroupBox.Controls.Add(this.StudentAttendancedataGridView);
            this.StudentAttendanceGroupBox.Controls.Add(this.button1);
            this.StudentAttendanceGroupBox.Controls.Add(this.textBox2);
            this.StudentAttendanceGroupBox.Controls.Add(this.label1);
            this.StudentAttendanceGroupBox.Controls.Add(this.Updatebtn);
            this.StudentAttendanceGroupBox.Controls.Add(this.button3);
            this.StudentAttendanceGroupBox.Controls.Add(this.StudentRollNocombobox);
            this.StudentAttendanceGroupBox.Controls.Add(this.StudentRollNolbl);
            this.StudentAttendanceGroupBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentAttendanceGroupBox.Location = new System.Drawing.Point(230, 68);
            this.StudentAttendanceGroupBox.Name = "StudentAttendanceGroupBox";
            this.StudentAttendanceGroupBox.Size = new System.Drawing.Size(433, 455);
            this.StudentAttendanceGroupBox.TabIndex = 5;
            this.StudentAttendanceGroupBox.TabStop = false;
            this.StudentAttendanceGroupBox.Text = "StudentAttendance";
            // 
            // GetDatabtn
            // 
            this.GetDatabtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.GetDatabtn.FlatAppearance.BorderSize = 0;
            this.GetDatabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetDatabtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetDatabtn.ForeColor = System.Drawing.Color.White;
            this.GetDatabtn.Location = new System.Drawing.Point(6, 220);
            this.GetDatabtn.Name = "GetDatabtn";
            this.GetDatabtn.Size = new System.Drawing.Size(92, 23);
            this.GetDatabtn.TabIndex = 24;
            this.GetDatabtn.Text = "Get Data";
            this.GetDatabtn.UseVisualStyleBackColor = false;
            this.GetDatabtn.Click += new System.EventHandler(this.GetDatabtn_Click);
            // 
            // AttendanceStatuscomboBox
            // 
            this.AttendanceStatuscomboBox.FormattingEnabled = true;
            this.AttendanceStatuscomboBox.Items.AddRange(new object[] {
            "Present",
            "Absent",
            "Leave",
            "Late"});
            this.AttendanceStatuscomboBox.Location = new System.Drawing.Point(253, 70);
            this.AttendanceStatuscomboBox.Name = "AttendanceStatuscomboBox";
            this.AttendanceStatuscomboBox.Size = new System.Drawing.Size(145, 24);
            this.AttendanceStatuscomboBox.TabIndex = 23;
            this.AttendanceStatuscomboBox.SelectedIndexChanged += new System.EventHandler(this.AttendanceStatuscomboBox_SelectedIndexChanged);
            // 
            // AttendanceStatuslbl
            // 
            this.AttendanceStatuslbl.AutoSize = true;
            this.AttendanceStatuslbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendanceStatuslbl.Location = new System.Drawing.Point(29, 73);
            this.AttendanceStatuslbl.Name = "AttendanceStatuslbl";
            this.AttendanceStatuslbl.Size = new System.Drawing.Size(127, 17);
            this.AttendanceStatuslbl.TabIndex = 22;
            this.AttendanceStatuslbl.Text = "Attendance Status";
            // 
            // StudentAttendancedataGridView
            // 
            this.StudentAttendancedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentAttendancedataGridView.Location = new System.Drawing.Point(4, 249);
            this.StudentAttendancedataGridView.Name = "StudentAttendancedataGridView";
            this.StudentAttendancedataGridView.Size = new System.Drawing.Size(423, 199);
            this.StudentAttendancedataGridView.TabIndex = 18;
            this.StudentAttendancedataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentAttendancedataGridView_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(323, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Search It";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(273, 152);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 23);
            this.textBox2.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Search";
            // 
            // Updatebtn
            // 
            this.Updatebtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Updatebtn.FlatAppearance.BorderSize = 0;
            this.Updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Updatebtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebtn.ForeColor = System.Drawing.Color.White;
            this.Updatebtn.Location = new System.Drawing.Point(114, 220);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(75, 23);
            this.Updatebtn.TabIndex = 14;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.UseVisualStyleBackColor = false;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(323, 109);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // StudentRollNocombobox
            // 
            this.StudentRollNocombobox.FormattingEnabled = true;
            this.StudentRollNocombobox.Location = new System.Drawing.Point(253, 29);
            this.StudentRollNocombobox.Name = "StudentRollNocombobox";
            this.StudentRollNocombobox.Size = new System.Drawing.Size(145, 24);
            this.StudentRollNocombobox.TabIndex = 12;
            this.StudentRollNocombobox.SelectedIndexChanged += new System.EventHandler(this.StudentRollNocombobox_SelectedIndexChanged);
            // 
            // StudentRollNolbl
            // 
            this.StudentRollNolbl.AutoSize = true;
            this.StudentRollNolbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentRollNolbl.Location = new System.Drawing.Point(29, 36);
            this.StudentRollNolbl.Name = "StudentRollNolbl";
            this.StudentRollNolbl.Size = new System.Drawing.Size(107, 17);
            this.StudentRollNolbl.TabIndex = 2;
            this.StudentRollNolbl.Text = "Student Roll No";
            // 
            // ClassAttendanceDatelbl
            // 
            this.ClassAttendanceDatelbl.AutoSize = true;
            this.ClassAttendanceDatelbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassAttendanceDatelbl.Location = new System.Drawing.Point(231, 37);
            this.ClassAttendanceDatelbl.Name = "ClassAttendanceDatelbl";
            this.ClassAttendanceDatelbl.Size = new System.Drawing.Size(158, 17);
            this.ClassAttendanceDatelbl.TabIndex = 20;
            this.ClassAttendanceDatelbl.Text = "Class Attendance Date";
            // 
            // ClassAttendanceDatedateTimePicker
            // 
            this.ClassAttendanceDatedateTimePicker.Location = new System.Drawing.Point(457, 33);
            this.ClassAttendanceDatedateTimePicker.Name = "ClassAttendanceDatedateTimePicker";
            this.ClassAttendanceDatedateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ClassAttendanceDatedateTimePicker.TabIndex = 21;
            this.ClassAttendanceDatedateTimePicker.ValueChanged += new System.EventHandler(this.ClassAttendanceDatedateTimePicker_ValueChanged);
            // 
            // AttendanceUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ClassAttendanceDatedateTimePicker);
            this.Controls.Add(this.StudentAttendanceGroupBox);
            this.Controls.Add(this.ClassAttendanceDatelbl);
            this.Name = "AttendanceUserControl";
            this.Size = new System.Drawing.Size(939, 526);
            this.Load += new System.EventHandler(this.AttendanceUserControl_Load);
            this.StudentAttendanceGroupBox.ResumeLayout(false);
            this.StudentAttendanceGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentAttendancedataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox StudentAttendanceGroupBox;
        private System.Windows.Forms.Label ClassAttendanceDatelbl;
        private System.Windows.Forms.DataGridView StudentAttendancedataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox StudentRollNocombobox;
        private System.Windows.Forms.Label StudentRollNolbl;
        private System.Windows.Forms.ComboBox AttendanceStatuscomboBox;
        private System.Windows.Forms.Label AttendanceStatuslbl;
        private System.Windows.Forms.DateTimePicker ClassAttendanceDatedateTimePicker;
        private System.Windows.Forms.Button GetDatabtn;
    }
}
