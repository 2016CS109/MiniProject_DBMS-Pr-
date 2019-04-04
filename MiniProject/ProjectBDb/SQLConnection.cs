using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ProjectBDb
{
    class SQLConnection
    {
        private static SQLConnection instance;
        private String ConnectionString = @"Data Source=MUHAMMADAWAIS\SQLEXPRESS;Initial Catalog=ProjectB;Persist Security Info=True;User ID=sa;Password=Google:811";
        private SqlConnection connection;
        //private SqlDataAdapter adapter;
        //private DataTable table;

        /// <summary>
        /// this function is singleton class instance
        /// </summary>
        /// <returns>return singleton class objects and functions</returns>
        public static SQLConnection getInstance()
        {
            if (instance == null)
                instance = new SQLConnection();
            return instance;
        }

        private SQLConnection()
        {
        }

        /// <summary>
        /// this function recieve connection string and check it.
        /// </summary>
        /// <returns>conection return either open or any fault.</returns>
        public SqlConnection getConnection()
        {
            connection = new SqlConnection(ConnectionString);
            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();
            return connection;
        }

        /// <summary>
        /// this function check that how many rows are affected after adding data.
        /// </summary>
        /// <param name="commnadText">it is query pass</param>
        /// <returns></returns>
        public int exectuteQuery(String commnadText)
        {
            connection = getConnection();
            SqlCommand cmd = new SqlCommand(commnadText, connection);
            int rows = cmd.ExecuteNonQuery();
            return rows;
        }

        /// <summary>
        /// this function basically fill select data from data base and fill in the table.
        /// </summary>
        /// <param name="commnadText">it is query of select whole data from table</param>
        /// <returns></returns>
        public SqlDataReader getData(String commnadText)
        {
            //connection = getConnection();
            //SqlCommand command = new SqlCommand(commnadText, connection);
            //adapter = new SqlDataAdapter(command);
            //table = new DataTable();
            //adapter.Fill(table);
            //return table;
            connection = getConnection();
            SqlCommand cmd = new SqlCommand(commnadText, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }
        /// <summary>
        /// this fucntion chk that connection is off or not.
        /// </summary>
        public void closeConnection()
        {
            if (connection != null)
                connection.Close();
        }

    }
}
