using System;
using System.Data;
using System.Data.OleDb;

namespace MIMS

{

    class AdoHelper
    {
        //get the connection string from the app.config file
        //Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Company.accdb
        static string connectionString = Properties.Settings.Default.DBConnection;

        //declare the db connection
        static OleDbConnection con = new OleDbConnection(connectionString);

        /// <summary>
        /// To Execute queries which returns result set (table / relation)
        /// </summary>
        /// <param name="query">the query string</param>
        /// <returns></returns>
        public static DataTable ExecuteDataTable(string query)
        {

            try
            {
                con.Open();
                OleDbCommand command = new OleDbCommand(query, con);
                OleDbDataAdapter tableAdapter = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                tableAdapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        /// <summary>
        /// To Execute update / insert / delete queries
        /// </summary>
        /// <param name="query">the query string</param>
        public static void ExecuteNonQuery(string query)
        {
            try
            {
                con.Open();
                OleDbCommand command = new OleDbCommand(query, con);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        /// <summary>
        /// To Execute queries which return scalar value
        /// </summary>
        /// <param name="query">the query string</param>
        public static object ExecuteScalar(string query)
        {
            try
            {
                con.Open();
                OleDbCommand command = new OleDbCommand(query, con);
                return command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
