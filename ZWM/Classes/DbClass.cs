using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZWM.Classes
{
    class DbClass
    {
        private const string conectionStringToBaseZwm = "Data Source=SEBASTIAN;Initial Catalog = ZWM; Integrated Security = True";

        public string conectionStringToBaseZwmProperty
        {
            get { return conectionStringToBaseZwm; }
        }

        public DbClass()
        {

        }

        public void ConnectionToDataBaseZwm(string myQuery, int whatToDo, out bool finished)
        {
            finished = false;
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = conectionStringToBaseZwm;

            SqlCommand sqlCommand = new SqlCommand();

            try
            {
                sqlConnection.Open();
                switch (whatToDo)
                {
                    case 1:

                        MySqlLoginMethod(sqlConnection, myQuery, out finished);


                        break;
                    case 2:
                        MySqlAddUserMethod(sqlConnection, myQuery, out finished);
                        break;
                    case 3:

                        break;
                    case 4:
                        break;

                    default:
                        break;
                }

            }
            catch (System.Data.SqlClient.SqlException se)
            {
                throw se;
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }

            }
        }

        public void ConnectionToDataBaseZwmnAndFindLastId(string myQuery, int whatToDo, out int finished)
        {
            finished = 0;
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = conectionStringToBaseZwm;

            SqlCommand sqlCommand = new SqlCommand();

            try
            {
                sqlConnection.Open();
                FindLastOrderID(sqlConnection, myQuery, out finished);

            }
            catch (System.Data.SqlClient.SqlException se)
            {
                throw se;
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }

            }
        }


        private int FindLastOrderID(SqlConnection sqlConnection, string myQuery, out int finished)
        {
            finished = 0;

            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = myQuery;
            finished = 0;
            int? isDone;
           

            isDone = sqlCommand.ExecuteNonQuery();

            if (isDone != null)
            {
                finished = (int)isDone;
            }

            return finished;
        }

        private bool MySqlAddUserMethod(SqlConnection sqlConnection, string myQuery, out bool finished)
        {
            finished = false;
            int isDone = 0;

            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = myQuery;

            isDone = sqlCommand.ExecuteNonQuery();

            if (isDone != 0)
            {
                finished = true;
            }

            return finished;
        }

        private bool MySqlLoginMethod(SqlConnection sqlConnection, string myQuery, out bool finished)
        {
            finished = false;


            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = myQuery;


            int? isDone = (int?)sqlCommand.ExecuteScalar();

            if (isDone != null)
            {
                if (isDone > 0 && (finished == false))
                {
                    finished = true;
                }
            }
            return finished;
        }
    }
}
