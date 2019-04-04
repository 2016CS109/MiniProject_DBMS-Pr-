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
    public partial class CloUserControl : UserControl
    {
        public int selectedId;
        public CloUserControl()
        {
            InitializeComponent();
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                String cmd = String.Format("INSERT INTO Clo(Name, DateCreated, DateUpdated) values('{0}','{1}', '{2}')", CloNametxtbox.Text, DateTime.Now, DateTime.Now);
                int rows = SQLConnection.getInstance().exectuteQuery(cmd);
                MessageBox.Show(String.Format("{0} rows affected", rows));
                CloNametxtbox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetDatabtn_Click(object sender, EventArgs e)
        {
            String cmd = "Select * from Clo";
            var reader = SQLConnection.getInstance().getData(cmd);
            List<Clo> clos = new List<Clo>();
            while (reader.Read())
            {
                Clo clo = new Clo();
                clo.Id = (int)reader.GetValue(0);
                clo.Name = reader.GetString(1);
                clo.DateCreated = reader.GetDateTime(2);
                clo.DateUpdated = reader.GetDateTime(3);
                clos.Add(clo);
            }
            ClodataGridView.DataSource = clos;
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                String cmd = String.Format("UPDATE Clo SET Name = '"+ CloNametxtbox.Text +"', DateUpdated = '"+ DateTime.Now +"' WHERE Id = '"+ selectedId +"'");
                int rows = SQLConnection.getInstance().exectuteQuery(cmd);
                MessageBox.Show(String.Format("{0} rows affected", rows));
                CloNametxtbox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClodataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.ClodataGridView.Rows[e.RowIndex];
                CloNametxtbox.Text = row.Cells["Name"].Value.ToString();
                selectedId = (int)row.Cells["Id"].Value;
            }
        }

        private void SearchItbtn_Click(object sender, EventArgs e)
        {
            String cmd = "Select * from Clo WHERE Name = '" + Searchtxtbox.Text + "'";
            var reader = SQLConnection.getInstance().getData(cmd);
            List<Clo> clos = new List<Clo>();
            while (reader.Read())
            {
                Clo clo = new Clo();
                clo.Id = (int)reader.GetValue(0);
                clo.Name = reader.GetString(1);
                clo.DateCreated = reader.GetDateTime(2);
                clo.DateUpdated = reader.GetDateTime(3);
                clos.Add(clo);
            }
            ClodataGridView.DataSource = clos;
        }
    }
}
