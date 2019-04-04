namespace ProjectBDb
{
    partial class StudentUserControl
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
            this.StudentInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.Savebtn = new System.Windows.Forms.Button();
            this.StatuscomboBox = new System.Windows.Forms.ComboBox();
            this.RegisterationNumbertxtbox = new System.Windows.Forms.TextBox();
            this.Emailtxtbox = new System.Windows.Forms.TextBox();
            this.Contacttxtbox = new System.Windows.Forms.TextBox();
            this.LastNametxtbox = new System.Windows.Forms.TextBox();
            this.FirstNametxtbox = new System.Windows.Forms.TextBox();
            this.Statuslbl = new System.Windows.Forms.Label();
            this.RegisterationNumberlbl = new System.Windows.Forms.Label();
            this.Emaillbl = new System.Windows.Forms.Label();
            this.Contactlbl = new System.Windows.Forms.Label();
            this.LastNamelbl = new System.Windows.Forms.Label();
            this.FirstNamelbl = new System.Windows.Forms.Label();
            this.StudentdataGridView = new System.Windows.Forms.DataGridView();
            this.Searchlbl = new System.Windows.Forms.Label();
            this.Searchtxtbox = new System.Windows.Forms.TextBox();
            this.SearchItbtn = new System.Windows.Forms.Button();
            this.Editbtn = new System.Windows.Forms.Button();
            this.GetDatabtn = new System.Windows.Forms.Button();
            this.StudentInfoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentInfoGroupBox
            // 
            this.StudentInfoGroupBox.Controls.Add(this.Savebtn);
            this.StudentInfoGroupBox.Controls.Add(this.StatuscomboBox);
            this.StudentInfoGroupBox.Controls.Add(this.RegisterationNumbertxtbox);
            this.StudentInfoGroupBox.Controls.Add(this.Emailtxtbox);
            this.StudentInfoGroupBox.Controls.Add(this.Contacttxtbox);
            this.StudentInfoGroupBox.Controls.Add(this.LastNametxtbox);
            this.StudentInfoGroupBox.Controls.Add(this.FirstNametxtbox);
            this.StudentInfoGroupBox.Controls.Add(this.Statuslbl);
            this.StudentInfoGroupBox.Controls.Add(this.RegisterationNumberlbl);
            this.StudentInfoGroupBox.Controls.Add(this.Emaillbl);
            this.StudentInfoGroupBox.Controls.Add(this.Contactlbl);
            this.StudentInfoGroupBox.Controls.Add(this.LastNamelbl);
            this.StudentInfoGroupBox.Controls.Add(this.FirstNamelbl);
            this.StudentInfoGroupBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentInfoGroupBox.Location = new System.Drawing.Point(122, 16);
            this.StudentInfoGroupBox.Name = "StudentInfoGroupBox";
            this.StudentInfoGroupBox.Size = new System.Drawing.Size(675, 192);
            this.StudentInfoGroupBox.TabIndex = 0;
            this.StudentInfoGroupBox.TabStop = false;
            this.StudentInfoGroupBox.Text = "Student\'s Info";
            // 
            // Savebtn
            // 
            this.Savebtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Savebtn.FlatAppearance.BorderSize = 0;
            this.Savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Savebtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Savebtn.ForeColor = System.Drawing.Color.White;
            this.Savebtn.Location = new System.Drawing.Point(565, 158);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(75, 23);
            this.Savebtn.TabIndex = 12;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = false;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // StatuscomboBox
            // 
            this.StatuscomboBox.FormattingEnabled = true;
            this.StatuscomboBox.Items.AddRange(new object[] {
            "Active",
            "InActive"});
            this.StatuscomboBox.Location = new System.Drawing.Point(515, 112);
            this.StatuscomboBox.Name = "StatuscomboBox";
            this.StatuscomboBox.Size = new System.Drawing.Size(125, 24);
            this.StatuscomboBox.TabIndex = 11;
            this.StatuscomboBox.SelectedIndexChanged += new System.EventHandler(this.StatuscomboBox_SelectedIndexChanged);
            // 
            // RegisterationNumbertxtbox
            // 
            this.RegisterationNumbertxtbox.Location = new System.Drawing.Point(229, 113);
            this.RegisterationNumbertxtbox.Name = "RegisterationNumbertxtbox";
            this.RegisterationNumbertxtbox.Size = new System.Drawing.Size(128, 23);
            this.RegisterationNumbertxtbox.TabIndex = 10;
            // 
            // Emailtxtbox
            // 
            this.Emailtxtbox.Location = new System.Drawing.Point(515, 71);
            this.Emailtxtbox.Name = "Emailtxtbox";
            this.Emailtxtbox.Size = new System.Drawing.Size(125, 23);
            this.Emailtxtbox.TabIndex = 9;
            // 
            // Contacttxtbox
            // 
            this.Contacttxtbox.Location = new System.Drawing.Point(229, 71);
            this.Contacttxtbox.Name = "Contacttxtbox";
            this.Contacttxtbox.Size = new System.Drawing.Size(128, 23);
            this.Contacttxtbox.TabIndex = 8;
            // 
            // LastNametxtbox
            // 
            this.LastNametxtbox.Location = new System.Drawing.Point(515, 31);
            this.LastNametxtbox.Name = "LastNametxtbox";
            this.LastNametxtbox.Size = new System.Drawing.Size(125, 23);
            this.LastNametxtbox.TabIndex = 7;
            // 
            // FirstNametxtbox
            // 
            this.FirstNametxtbox.Location = new System.Drawing.Point(229, 31);
            this.FirstNametxtbox.Name = "FirstNametxtbox";
            this.FirstNametxtbox.Size = new System.Drawing.Size(128, 23);
            this.FirstNametxtbox.TabIndex = 6;
            // 
            // Statuslbl
            // 
            this.Statuslbl.AutoSize = true;
            this.Statuslbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Statuslbl.Location = new System.Drawing.Point(405, 116);
            this.Statuslbl.Name = "Statuslbl";
            this.Statuslbl.Size = new System.Drawing.Size(46, 17);
            this.Statuslbl.TabIndex = 5;
            this.Statuslbl.Text = "Status";
            // 
            // RegisterationNumberlbl
            // 
            this.RegisterationNumberlbl.AutoSize = true;
            this.RegisterationNumberlbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterationNumberlbl.Location = new System.Drawing.Point(46, 116);
            this.RegisterationNumberlbl.Name = "RegisterationNumberlbl";
            this.RegisterationNumberlbl.Size = new System.Drawing.Size(144, 17);
            this.RegisterationNumberlbl.TabIndex = 4;
            this.RegisterationNumberlbl.Text = "RegisterationNumber";
            // 
            // Emaillbl
            // 
            this.Emaillbl.AutoSize = true;
            this.Emaillbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emaillbl.Location = new System.Drawing.Point(405, 71);
            this.Emaillbl.Name = "Emaillbl";
            this.Emaillbl.Size = new System.Drawing.Size(43, 17);
            this.Emaillbl.TabIndex = 3;
            this.Emaillbl.Text = "Email";
            // 
            // Contactlbl
            // 
            this.Contactlbl.AutoSize = true;
            this.Contactlbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contactlbl.Location = new System.Drawing.Point(46, 71);
            this.Contactlbl.Name = "Contactlbl";
            this.Contactlbl.Size = new System.Drawing.Size(63, 17);
            this.Contactlbl.TabIndex = 2;
            this.Contactlbl.Text = "Contact";
            // 
            // LastNamelbl
            // 
            this.LastNamelbl.AutoSize = true;
            this.LastNamelbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNamelbl.Location = new System.Drawing.Point(405, 31);
            this.LastNamelbl.Name = "LastNamelbl";
            this.LastNamelbl.Size = new System.Drawing.Size(73, 17);
            this.LastNamelbl.TabIndex = 1;
            this.LastNamelbl.Text = "LastName";
            // 
            // FirstNamelbl
            // 
            this.FirstNamelbl.AutoSize = true;
            this.FirstNamelbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNamelbl.Location = new System.Drawing.Point(46, 31);
            this.FirstNamelbl.Name = "FirstNamelbl";
            this.FirstNamelbl.Size = new System.Drawing.Size(71, 17);
            this.FirstNamelbl.TabIndex = 0;
            this.FirstNamelbl.Text = "FirstName";
            // 
            // StudentdataGridView
            // 
            this.StudentdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentdataGridView.Location = new System.Drawing.Point(67, 293);
            this.StudentdataGridView.Name = "StudentdataGridView";
            this.StudentdataGridView.Size = new System.Drawing.Size(805, 218);
            this.StudentdataGridView.TabIndex = 1;
            this.StudentdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentdataGridView_CellContentClick);
            // 
            // Searchlbl
            // 
            this.Searchlbl.AutoSize = true;
            this.Searchlbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchlbl.Location = new System.Drawing.Point(527, 225);
            this.Searchlbl.Name = "Searchlbl";
            this.Searchlbl.Size = new System.Drawing.Size(51, 17);
            this.Searchlbl.TabIndex = 2;
            this.Searchlbl.Text = "Search";
            // 
            // Searchtxtbox
            // 
            this.Searchtxtbox.Location = new System.Drawing.Point(637, 222);
            this.Searchtxtbox.Name = "Searchtxtbox";
            this.Searchtxtbox.Size = new System.Drawing.Size(125, 20);
            this.Searchtxtbox.TabIndex = 3;
            // 
            // SearchItbtn
            // 
            this.SearchItbtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.SearchItbtn.FlatAppearance.BorderSize = 0;
            this.SearchItbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchItbtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchItbtn.ForeColor = System.Drawing.Color.White;
            this.SearchItbtn.Location = new System.Drawing.Point(687, 252);
            this.SearchItbtn.Name = "SearchItbtn";
            this.SearchItbtn.Size = new System.Drawing.Size(75, 23);
            this.SearchItbtn.TabIndex = 4;
            this.SearchItbtn.Text = "Search It";
            this.SearchItbtn.UseVisualStyleBackColor = false;
            this.SearchItbtn.Click += new System.EventHandler(this.SearchItbtn_Click);
            // 
            // Editbtn
            // 
            this.Editbtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Editbtn.FlatAppearance.BorderSize = 0;
            this.Editbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Editbtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editbtn.ForeColor = System.Drawing.Color.White;
            this.Editbtn.Location = new System.Drawing.Point(171, 264);
            this.Editbtn.Name = "Editbtn";
            this.Editbtn.Size = new System.Drawing.Size(75, 23);
            this.Editbtn.TabIndex = 5;
            this.Editbtn.Text = "Edit";
            this.Editbtn.UseVisualStyleBackColor = false;
            this.Editbtn.Click += new System.EventHandler(this.Editbtn_Click);
            // 
            // GetDatabtn
            // 
            this.GetDatabtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.GetDatabtn.FlatAppearance.BorderSize = 0;
            this.GetDatabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetDatabtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetDatabtn.ForeColor = System.Drawing.Color.White;
            this.GetDatabtn.Location = new System.Drawing.Point(67, 264);
            this.GetDatabtn.Name = "GetDatabtn";
            this.GetDatabtn.Size = new System.Drawing.Size(93, 23);
            this.GetDatabtn.TabIndex = 6;
            this.GetDatabtn.Text = "Get Data";
            this.GetDatabtn.UseVisualStyleBackColor = false;
            this.GetDatabtn.Click += new System.EventHandler(this.GetDatabtn_Click);
            // 
            // StudentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GetDatabtn);
            this.Controls.Add(this.Editbtn);
            this.Controls.Add(this.SearchItbtn);
            this.Controls.Add(this.Searchtxtbox);
            this.Controls.Add(this.Searchlbl);
            this.Controls.Add(this.StudentdataGridView);
            this.Controls.Add(this.StudentInfoGroupBox);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "StudentUserControl";
            this.Size = new System.Drawing.Size(939, 526);
            this.Load += new System.EventHandler(this.StudentUserControl_Load);
            this.StudentInfoGroupBox.ResumeLayout(false);
            this.StudentInfoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox StudentInfoGroupBox;
        private System.Windows.Forms.Label Statuslbl;
        private System.Windows.Forms.Label RegisterationNumberlbl;
        private System.Windows.Forms.Label Emaillbl;
        private System.Windows.Forms.Label Contactlbl;
        private System.Windows.Forms.Label LastNamelbl;
        private System.Windows.Forms.Label FirstNamelbl;
        private System.Windows.Forms.TextBox RegisterationNumbertxtbox;
        private System.Windows.Forms.TextBox Emailtxtbox;
        private System.Windows.Forms.TextBox Contacttxtbox;
        private System.Windows.Forms.TextBox LastNametxtbox;
        private System.Windows.Forms.TextBox FirstNametxtbox;
        private System.Windows.Forms.ComboBox StatuscomboBox;
        private System.Windows.Forms.DataGridView StudentdataGridView;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Label Searchlbl;
        private System.Windows.Forms.TextBox Searchtxtbox;
        private System.Windows.Forms.Button SearchItbtn;
        private System.Windows.Forms.Button Editbtn;
        private System.Windows.Forms.Button GetDatabtn;
    }
}
