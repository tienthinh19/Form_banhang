using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BuiTienThinh_22102363
{
    internal class SqlDataAccessHelper
    {
        private static SqlDataAdapter myAdapter;
        private static SqlConnection conn;

        public SqlDataAccessHelper()
        {
            myAdapter = new SqlDataAdapter();
            string constr = ConfigurationManager.ConnectionStrings["LoveStore2"].ConnectionString;
            conn = new SqlConnection(constr);
        }

        private static SqlConnection OpenConnection()
        {
            if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
            {
                conn.Open();
            }
            return conn;
        }

        // Hàm thực hiện các câu SELECT không có điều kiện
        public static DataTable ExecuteSelectAllQuery(String _query)
        {
            SqlCommand myCommand = new SqlCommand();
            DataTable dataTable = new DataTable();

            DataSet ds = new DataSet();
            try
            {
                myCommand.Connection = OpenConnection();
                myCommand.CommandText = _query;

                myCommand.ExecuteNonQuery();
                myAdapter.SelectCommand = myCommand;

                myAdapter.Fill(ds);
                dataTable = ds.Tables[0];
            }
            catch (SqlException e)
            {
                Console.Write("Error - Connection.executeSelectQuery - Query: " + _query + " \nException: " + e.StackTrace.ToString());
                return null;
            }

            return dataTable;
        }

        public static DataTable ExecuteSelectQuery(String _query, SqlParameter sqlParameter)
        {
            SqlCommand myCommand = new SqlCommand();
            DataTable dataTable = new DataTable();
            //dataTable = null;
            DataSet ds = new DataSet();
            try
            {
                myCommand.Connection = OpenConnection();
                myCommand.CommandText = _query;
                myCommand.Parameters.Add(sqlParameter);
                myCommand.ExecuteNonQuery();
                myAdapter.SelectCommand = myCommand;
                myAdapter.Fill(ds);
                dataTable = ds.Tables[0];
            }
            catch (SqlException e)
            {
                Console.Write("Error - Connection.executeSelectQuery - Query: " + _query + " \nException: " + e.StackTrace.ToString());
                return null;
            }
            finally
            {

            }
            return dataTable;
        }
        public static bool ExecuteInsertQuery(String _query, SqlParameter[] sqlParameter)
        {
            SqlCommand myCommand = new SqlCommand();
            try
            {
                myCommand.Connection = OpenConnection();
                myCommand.CommandText = _query;
                myCommand.Parameters.AddRange(sqlParameter);
                //  myAdapter.InsertCommand = myCommand;
                myCommand.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.Write("Error - Connection.executeInsertQuery - Query: " + _query + " \nException: \n" + e.StackTrace.ToString());
                return false;
            }
            finally
            {
            }
            return true;
        }
        public static bool ExecuteDeleteQuery(String _query, SqlParameter sqlParameter)
        {
            SqlCommand myCommand = new SqlCommand();
            try
            {
                myCommand.Connection = OpenConnection();
                myCommand.CommandText = _query;
                myCommand.Parameters.Add(sqlParameter);
                myCommand.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.Write("Error - Connection.executeDeleteQuery - Query: " + _query + " \nException: \n" + e.StackTrace.ToString());
                return false;
            }
            return true;
        }

        public static bool UpdateAdapter(String _Insquery, String _Updatequery, String _Deletequery, SqlParameter[] sqlParameter1, SqlParameter[] sqlParameter2, SqlParameter[] sqlParameter3, DataTable dt)
        {
            SqlCommand InsertCommand = new SqlCommand();
            SqlCommand UpdateCommand = new SqlCommand();
            SqlCommand DeleteCommand = new SqlCommand();
            
            try
            {
                InsertCommand.Connection = OpenConnection();
                UpdateCommand.Connection = OpenConnection();
                DeleteCommand.Connection = OpenConnection();

                InsertCommand.CommandText = _Insquery;
                UpdateCommand.CommandText = _Updatequery;
                DeleteCommand.CommandText = _Deletequery;

                DeleteCommand.Parameters.AddRange(sqlParameter3);
                UpdateCommand.Parameters.AddRange(sqlParameter2);
                InsertCommand.Parameters.AddRange(sqlParameter1);

                
                myAdapter.InsertCommand = InsertCommand;
                myAdapter.UpdateCommand = UpdateCommand;
                myAdapter.DeleteCommand = DeleteCommand;

                myAdapter.Update(dt);

            }
            catch (SqlException e)
            {
                Console.Write("Error - Connection.executeSelectQuery - Query: " + "" + " \nException: " + e.StackTrace.ToString());
                return false;
            }
            finally
            {

            }
            return true;
        }
    }
}
