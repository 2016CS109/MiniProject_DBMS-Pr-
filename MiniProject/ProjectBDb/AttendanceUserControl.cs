using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectBDb.Classess;

namespace ProjectBDb
{
    public partial class AttendanceUserControl : UserControl
    {
        public int StatusValue;
        public int ClassAttendanceId;
        public int StudentId;
        public string RollNumber;
        public  DateTime ClassAttendanceDate;
        public int SelectedClassAttendanceId;
        public int SelectedStudentId;
        public AttendanceUserControl()
        {
            InitializeComponent();
        }

        private void AttendanceUserControl_Load(object sender, EventArgs e)
        {
            String cmd = "Select RegistrationNumber from Student";
            var reader = SQLConnection.getInstance().getData(cmd);
            StudentRollNocombobox.DisplayMember = "Text";
            StudentRollNocombobox.ValueMember = "Value";
            while (reader.Read())
            {
                StudentRollNocombobox.Items.Add(new { Text = reader.GetString(0), Value = reader.GetString(0) });
            }
        }
        private void StudentRollNocombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String cmd = "Select Id from Student WHERE RegistrationNumber = '" + StudentRollNocombobox.Text.ToString() + "'";
            var reader = SQLConnection.getInstance().getData(cmd);
            while (reader.Read())
            {
                StudentId = Convert.ToInt32(reader.GetValue(0));
            }           
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                String cmd = String.Format("INSERT INTO StudentAttendance(AttendanceId, StudentId, AttendanceStatus) values('{0}','{1}', '{2}')", ClassAttendanceId, StudentId, StatusValue);
                int rows = SQLConnection.getInstance().exectuteQuery(cmd);
                MessageBox.Show(String.Format("{0} rows affected", rows));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AttendanceStatuscomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AttendanceStatuscomboBox.SelectedItem.ToString() == "Present")
            {
                StatusValue = 1;
            }
            if (AttendanceStatuscomboBox.SelectedItem.ToString() == "Absent")
            {
                StatusValue = 2;
            }
            if (AttendanceStatuscomboBox.SelectedItem.ToString() == "Leave")
            {
                StatusValue = 3;
            }
            if (AttendanceStatuscomboBox.SelectedItem.ToString() == "Late")
            {
                StatusValue = 4;
            }
        }

        private void ClassAttendanceDatedateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            String cmd = String.Format("INSERT INTO ClassAttendance(AttendanceDate) values('{0}')", Convert.ToDateTime(ClassAttendanceDatedateTimePicker.Text));
            int rows = SQLConnection.getInstance().exectuteQuery(cmd);
            MessageBox.Show(String.Format("{0} rows affected", rows));
            String cmd1 = "Select Id from ClassAttendance WHERE AttendanceDate = '" + Convert.ToDateTime(ClassAttendanceDatedateTimePicker.Text) + "'";
            var reader = SQLConnection.getInstance().getData(cmd1);
            while (reader.Read())
            {
                ClassAttendanceId = Convert.ToInt32(reader.GetValue(0));
            }
        }

        private void GetDatabtn_Click(object sender, EventArgs e)
        {
            string Status = "null";
            String cmd = "Select * from StudentAttendance";
            var reader = SQLConnection.getInstance().getData(cmd);
            List<StudentAttendance> stdsAttendance = new List<StudentAttendance>();
            while (reader.Read())
            {
                StudentAttendance stdAttndc = new StudentAttendance();
                ClassAttendanceId = Convert.ToInt32(reader.GetValue(0));
                ClassAttendance(ClassAttendanceId);
                stdAttndc.AttendanceDate = ClassAttendanceDate;
                StudentId = Convert.ToInt32(reader.GetValue(1));
                StudentRollNumber(StudentId);
                stdAttndc.RegistrationNumber = RollNumber;
                if ((int)reader.GetValue(2) == 1)
                {
                    Status = "Present";
                }
                if ((int)reader.GetValue(2) == 2)
                {
                    Status = "Absent";
                }
                if ((int)reader.GetValue(2) == 3)
                {
                    Status = "Leave";
                }
                if ((int)reader.GetValue(2) == 4)
                {
                    Status = "Late";
                }
                stdAttndc.AttendanceStatus = Status;
                stdsAttendance.Add(stdAttndc);
            }
            StudentAttendancedataGridView.DataSource = stdsAttendance;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Status = "null";
            String Cmd = "Select Id from Student WHERE RegistrationNumber = '" + textBox2.Text + "'";
            var Reader = SQLConnection.getInstance().getData(Cmd);
            while (Reader.Read())
            {
                StudentId = (int)Reader.GetValue(0);
            }
            String cmd = "Select * from StudentAttendance WHERE StudentId = '"+ StudentId +"' ";
            var reader = SQLConnection.getInstance().getData(cmd);
            List<StudentAttendance> stdsAttendance = new List<StudentAttendance>();
            while (reader.Read())
            {
                StudentAttendance stdAttndc = new StudentAttendance();
                ClassAttendanceId = Convert.ToInt32(reader.GetValue(0));
                ClassAttendance(ClassAttendanceId);
                stdAttndc.AttendanceDate = ClassAttendanceDate;
                StudentId = Convert.ToInt32(reader.GetValue(1));
                StudentRollNumber(StudentId);
                stdAttndc.RegistrationNumber = RollNumber;
                if ((int)reader.GetValue(2) == 1)
                {
                    Status = "Present";
                }
                if ((int)reader.GetValue(2) == 2)
                {
                    Status = "Absent";
                }
                if ((int)reader.GetValue(2) == 3)
                {
                    Status = "Leave";
                }
                if ((int)reader.GetValue(2) == 4)
                {
                    Status = "Late";
                }
                stdAttndc.AttendanceStatus = Status;
                stdsAttendance.Add(stdAttndc);
            }
            StudentAttendancedataGridView.DataSource = stdsAttendance;

        }
        public void StudentRollNumber(int StudentId)
        {
            String cmd = "Select RegistrationNumber from Student WHERE Id = '" + StudentId + "'";
            var reader = SQLConnection.getInstance().getData(cmd);
            while (reader.Read())
            {
                RollNumber = reader.GetString(0);
            }
        }
        public void StudentRollNumberId(string StudentRollNo)
        {
            String cmd = "Select Id from Student WHERE RegistrationNumber = '" + StudentRollNo + "'";
            var reader = SQLConnection.getInstance().getData(cmd);
            while (reader.Read())
            {
                SelectedStudentId = (int)reader.GetValue(0);
            }
        }
        public void ClassAttendance(int ClassAttendanceId)
        {
            String cmd = "Select AttendanceDate from ClassAttendance WHERE Id = '" + ClassAttendanceId + "'";
            var reader = SQLConnection.getInstance().getData(cmd);
            while (reader.Read())
            {
                ClassAttendanceDate = reader.GetDateTime(0);
            }
        }
        public void ClassAttendanceID(DateTime ClassAttendancedDate)
        {
            String cmd = "Select Id from ClassAttendance WHERE AttendanceDate = '" + ClassAttendancedDate + "'";
            var reader = SQLConnection.getInstance().getData(cmd);
            while (reader.Read())
            {
                SelectedClassAttendanceId = (int)reader.GetValue(0);
            }
        }
        private void StudentAttendancedataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.StudentAttendancedataGridView.Rows[e.RowIndex];
                ClassAttendanceDatedateTimePicker.Text = row.Cells["AttendanceDate"].Value.ToString();
                StudentRollNocombobox.Text = row.Cells["RegistrationNumber"].Value.ToString();
                StudentRollNumberId(StudentRollNocombobox.Text);
                ClassAttendanceID(Convert.ToDateTime(ClassAttendanceDatedateTimePicker.Text));
            }
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                //AttendanceId = '" + SelectedClassAttendanceId + "' AND
                String cmd = String.Format("UPDATE StudentAttendance SET AttendanceStatus = '" + StatusValue + "' where StudentId = '"+ SelectedStudentId +"'");
                int rows = SQLConnection.getInstance().exectuteQuery(cmd);
                MessageBox.Show(String.Format("{0} rows affected", rows));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
