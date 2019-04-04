using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjectBDb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = Home_btn.Height;
            SidePanel.Top = Home_btn.Top;
            homeUserControl1.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Student_btn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = Student_btn.Height;
            SidePanel.Top = Student_btn.Top;
            studentUserControl1.BringToFront();
        }

        private void StudentResult_btn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = StudentResult_btn.Height;
            SidePanel.Top = StudentResult_btn.Top;
            studentResultUserControl1.BringToFront();
        }

        private void Rubric_btn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = Rubric_btn.Height;
            SidePanel.Top = Rubric_btn.Top;
            rubricUserControl2.BringToFront();
        }

        private void Assessment_btn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = Assessment_btn.Height;
            SidePanel.Top = Assessment_btn.Top;
            assessmentUserControl1.BringToFront();
        }

        private void Home_btn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = Home_btn.Height;
            SidePanel.Top = Home_btn.Top;
            homeUserControl1.BringToFront();
        }

        private void Clo_btn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = Clo_btn.Height;
            SidePanel.Top = Clo_btn.Top;
            cloUserControl1.BringToFront();
        }

        private void Attendance_btn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = Attendance_btn.Height;
            SidePanel.Top = Attendance_btn.Top;
            attendanceUserControl1.BringToFront();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
