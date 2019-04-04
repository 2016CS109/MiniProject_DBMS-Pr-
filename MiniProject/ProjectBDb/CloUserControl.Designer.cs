namespace ProjectBDb
{
    partial class CloUserControl
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
            this.CloGroupBox = new System.Windows.Forms.GroupBox();
            this.Savebtn = new System.Windows.Forms.Button();
            this.CloNametxtbox = new System.Windows.Forms.TextBox();
            this.CloNamelbl = new System.Windows.Forms.Label();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.SearchItbtn = new System.Windows.Forms.Button();
            this.Searchtxtbox = new System.Windows.Forms.TextBox();
            this.Searchlbl = new System.Windows.Forms.Label();
            this.ClodataGridView = new System.Windows.Forms.DataGridView();
            this.GetDatabtn = new System.Windows.Forms.Button();
            this.CloGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClodataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CloGroupBox
            // 
            this.CloGroupBox.Controls.Add(this.Savebtn);
            this.CloGroupBox.Controls.Add(this.CloNametxtbox);
            this.CloGroupBox.Controls.Add(this.CloNamelbl);
            this.CloGroupBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloGroupBox.Location = new System.Drawing.Point(227, 11);
            this.CloGroupBox.Name = "CloGroupBox";
            this.CloGroupBox.Size = new System.Drawing.Size(485, 180);
            this.CloGroupBox.TabIndex = 0;
            this.CloGroupBox.TabStop = false;
            this.CloGroupBox.Text = "Clo\'s Info";
            // 
            // Savebtn
            // 
            this.Savebtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Savebtn.FlatAppearance.BorderSize = 0;
            this.Savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Savebtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Savebtn.ForeColor = System.Drawing.Color.White;
            this.Savebtn.Location = new System.Drawing.Point(375, 151);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(75, 23);
            this.Savebtn.TabIndex = 13;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = false;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // CloNametxtbox
            // 
            this.CloNametxtbox.Location = new System.Drawing.Point(223, 40);
            this.CloNametxtbox.Multiline = true;
            this.CloNametxtbox.Name = "CloNametxtbox";
            this.CloNametxtbox.Size = new System.Drawing.Size(196, 89);
            this.CloNametxtbox.TabIndex = 1;
            // 
            // CloNamelbl
            // 
            this.CloNamelbl.AutoSize = true;
            this.CloNamelbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloNamelbl.Location = new System.Drawing.Point(51, 40);
            this.CloNamelbl.Name = "CloNamelbl";
            this.CloNamelbl.Size = new System.Drawing.Size(75, 17);
            this.CloNamelbl.TabIndex = 0;
            this.CloNamelbl.Text = "Clo Name";
            // 
            // Updatebtn
            // 
            this.Updatebtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Updatebtn.FlatAppearance.BorderSize = 0;
            this.Updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Updatebtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebtn.ForeColor = System.Drawing.Color.White;
            this.Updatebtn.Location = new System.Drawing.Point(293, 260);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(75, 23);
            this.Updatebtn.TabIndex = 6;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.UseVisualStyleBackColor = false;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // SearchItbtn
            // 
            this.SearchItbtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.SearchItbtn.FlatAppearance.BorderSize = 0;
            this.SearchItbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchItbtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchItbtn.ForeColor = System.Drawing.Color.White;
            this.SearchItbtn.Location = new System.Drawing.Point(637, 250);
            this.SearchItbtn.Name = "SearchItbtn";
            this.SearchItbtn.Size = new System.Drawing.Size(75, 23);
            this.SearchItbtn.TabIndex = 7;
            this.SearchItbtn.Text = "Search It";
            this.SearchItbtn.UseVisualStyleBackColor = false;
            this.SearchItbtn.Click += new System.EventHandler(this.SearchItbtn_Click);
            // 
            // Searchtxtbox
            // 
            this.Searchtxtbox.Location = new System.Drawing.Point(587, 214);
            this.Searchtxtbox.Name = "Searchtxtbox";
            this.Searchtxtbox.Size = new System.Drawing.Size(125, 20);
            this.Searchtxtbox.TabIndex = 8;
            // 
            // Searchlbl
            // 
            this.Searchlbl.AutoSize = true;
            this.Searchlbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchlbl.Location = new System.Drawing.Point(509, 217);
            this.Searchlbl.Name = "Searchlbl";
            this.Searchlbl.Size = new System.Drawing.Size(51, 17);
            this.Searchlbl.TabIndex = 9;
            this.Searchlbl.Text = "Search";
            // 
            // ClodataGridView
            // 
            this.ClodataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClodataGridView.Location = new System.Drawing.Point(183, 289);
            this.ClodataGridView.Name = "ClodataGridView";
            this.ClodataGridView.Size = new System.Drawing.Size(586, 211);
            this.ClodataGridView.TabIndex = 10;
            this.ClodataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClodataGridView_CellContentClick);
            // 
            // GetDatabtn
            // 
            this.GetDatabtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.GetDatabtn.FlatAppearance.BorderSize = 0;
            this.GetDatabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetDatabtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetDatabtn.ForeColor = System.Drawing.Color.White;
            this.GetDatabtn.Location = new System.Drawing.Point(183, 260);
            this.GetDatabtn.Name = "GetDatabtn";
            this.GetDatabtn.Size = new System.Drawing.Size(94, 23);
            this.GetDatabtn.TabIndex = 11;
            this.GetDatabtn.Text = "Get Data";
            this.GetDatabtn.UseVisualStyleBackColor = false;
            this.GetDatabtn.Click += new System.EventHandler(this.GetDatabtn_Click);
            // 
            // CloUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GetDatabtn);
            this.Controls.Add(this.ClodataGridView);
            this.Controls.Add(this.Searchlbl);
            this.Controls.Add(this.Searchtxtbox);
            this.Controls.Add(this.SearchItbtn);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.CloGroupBox);
            this.Name = "CloUserControl";
            this.Size = new System.Drawing.Size(939, 526);
            this.CloGroupBox.ResumeLayout(false);
            this.CloGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClodataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox CloGroupBox;
        private System.Windows.Forms.TextBox CloNametxtbox;
        private System.Windows.Forms.Label CloNamelbl;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button SearchItbtn;
        private System.Windows.Forms.TextBox Searchtxtbox;
        private System.Windows.Forms.Label Searchlbl;
        private System.Windows.Forms.DataGridView ClodataGridView;
        private System.Windows.Forms.Button GetDatabtn;
    }
}
