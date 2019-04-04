namespace ProjectBDb
{
    partial class HomeUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeUserControl));
            this.MainpictureBox = new System.Windows.Forms.PictureBox();
            this.PencilLogopictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UETlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MainpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PencilLogopictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainpictureBox
            // 
            this.MainpictureBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MainpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("MainpictureBox.Image")));
            this.MainpictureBox.Location = new System.Drawing.Point(0, 237);
            this.MainpictureBox.Name = "MainpictureBox";
            this.MainpictureBox.Size = new System.Drawing.Size(939, 289);
            this.MainpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MainpictureBox.TabIndex = 0;
            this.MainpictureBox.TabStop = false;
            // 
            // PencilLogopictureBox
            // 
            this.PencilLogopictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PencilLogopictureBox.Image")));
            this.PencilLogopictureBox.Location = new System.Drawing.Point(66, 52);
            this.PencilLogopictureBox.Name = "PencilLogopictureBox";
            this.PencilLogopictureBox.Size = new System.Drawing.Size(142, 161);
            this.PencilLogopictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PencilLogopictureBox.TabIndex = 1;
            this.PencilLogopictureBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(296, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(383, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // UETlbl
            // 
            this.UETlbl.AutoSize = true;
            this.UETlbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UETlbl.Location = new System.Drawing.Point(268, 174);
            this.UETlbl.Name = "UETlbl";
            this.UETlbl.Size = new System.Drawing.Size(460, 23);
            this.UETlbl.TabIndex = 3;
            this.UETlbl.Text = "University of Engineering and Technology, Lahore";
            // 
            // HomeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.UETlbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PencilLogopictureBox);
            this.Controls.Add(this.MainpictureBox);
            this.Name = "HomeUserControl";
            this.Size = new System.Drawing.Size(939, 526);
            ((System.ComponentModel.ISupportInitialize)(this.MainpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PencilLogopictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MainpictureBox;
        private System.Windows.Forms.PictureBox PencilLogopictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label UETlbl;
    }
}
