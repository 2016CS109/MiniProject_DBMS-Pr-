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
    public partial class StudentUserControl : UserControl
    {
        public int StatusValue;
        public int selectedvalue;
        public StudentUserControl()
        {
            InitializeComponent();
        }
        private void Savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                String cmd = String.Format("INSERT INTO Student(FirstName, LastName, Contact, Email, RegistrationNumber, Status) values('{0}','{1}', '{2}', '{3}', '{4}', '{5}')", FirstNametxtbox.Text, LastNametxtbox.Text, Contacttxtbox.Text, Emailtxtbox.Text, RegisterationNumbertxtbox.Text, StatusValue);
                int rows = SQLConnection.getInstance().exectuteQuery(cmd);
                MessageBox.Show(String.Format("{0} rows affected", rows));
                CleartxtBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void StatuscomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StatuscomboBox.SelectedItem.ToString() == "Active")
            {
                StatusValue = 5;
            }
            if (StatuscomboBox.SelectedItem.ToString() == "InActive")
            {
                StatusValue = 6;
            }
        }

        private void StudentUserControl_Load(object sender, EventArgs e)
        {

        }

        private void SearchItbtn_Click(object sender, EventArgs e)
        {
            string Status = "null";
            String cmd = "Select * from Student WHERE RegistrationNumber = '"+ Searchtxtbox.Text +"'";
            var reader = SQLConnection.getInstance().getData(cmd);
            List<Student> students = new List<Student>();
            while (reader.Read())
            {
                Student std = new Student();
                std.Id = (int)reader.GetValue(0);
                std.FirstName = reader.GetString(1);
                std.LastName = reader.GetString(2);
                std.Contact = reader.GetString(3);
                std.Email = reader.GetString(4);
                std.RegistrationNumber = reader.GetString(5);
                if ((int)reader.GetValue(6) == 5)
                {
                    Status = "Active";
                }
                if ((int)reader.GetValue(6) == 6)
                {
                    Status = "InActive";
                }
                std.Status = Status;
                students.Add(std);
            }
            StudentdataGridView.DataSource = students;
        }

        private void GetDatabtn_Click(object sender, EventArgs e)
        {
            string Status = "null";
            String cmd = "Select * from Student";
            var reader = SQLConnection.getInstance().getData(cmd);
            List<Student> students = new List<Student>();
            while (reader.Read())
            {
                Student std = new Student();
                std.Id = (int)reader.GetValue(0);
                std.FirstName = reader.GetString(1);
                std.LastName = reader.GetString(2);
                std.Contact = reader.GetString(3);
                std.Email = reader.GetString(4);
                std.RegistrationNumber = reader.GetString(5);
                if((int)reader.GetValue(6) == 5)
                {
                    Status = "Active";
                }
                if ((int)reader.GetValue(6) == 6)
                {
                    Status = "InActive";
                }
                std.Status = Status;
                students.Add(std);
            }
            StudentdataGridView.DataSource = students;
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            try
            {
                String cmd = String.Format("UPDATE Student SET FirstName = '"+ FirstNametxtbox.Text + "', LastName = '"+LastNametxtbox.Text+"', Contact = '"+Contacttxtbox.Text+"', Email = '"+Emailtxtbox.Text+"', RegistrationNumber = '"+RegisterationNumbertxtbox.Text+"', Status = '"+StatusValue+"' where Id = '"+selectedvalue+"'");
                int rows = SQLConnection.getInstance().exectuteQuery(cmd);
                MessageBox.Show(String.Format("{0} rows affected", rows));
                CleartxtBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void StudentdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.StudentdataGridView.Rows[e.RowIndex];
                FirstNametxtbox.Text = row.Cells["FirstName"].Value.ToString();
                LastNametxtbox.Text = row.Cells["LastName"].Value.ToString();
                Contacttxtbox.Text = row.Cells["Contact"].Value.ToString();
                Emailtxtbox.Text = row.Cells["Email"].Value.ToString();
                RegisterationNumbertxtbox.Text = row.Cells["RegistrationNumber"].Value.ToString();
                selectedvalue = (int)row.Cells["Id"].Value;
            }
        }

        public void CleartxtBoxes()
        {
            FirstNametxtbox.Clear();
            LastNametxtbox.Clear();
            Contacttxtbox.Clear();
            Emailtxtbox.Clear();
            RegisterationNumbertxtbox.Clear();
            StatuscomboBox.ResetText();
        }
    }
}
