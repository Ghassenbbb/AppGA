using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.CompilerServices;

namespace AppGA
{

    public static class dbCon
    {
        private static string mainCo = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
        public static SqlConnection con = new SqlConnection(mainCo);

        public static DataSet querySelect(string query)
        {
            con.Open();
            var select = query;
            var dataAdapter = new SqlDataAdapter(select, con);
            con.Close();
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            return ds;
        }

        public static DataSet querySelect2(SqlCommand query)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            con.Open();
            adapter.SelectCommand = query;
            con.Close();
            var ds = new DataSet();
            adapter.Fill(ds);
            return ds;
        }


        public static int queryInsert(SqlCommand query)
        {
            con.Open();
            var numberOfInsertedRows = query.ExecuteNonQuery();
            con.Close();
            return numberOfInsertedRows;
        }

        public static bool CheckExistDB(string tableName, string Col, string Value)
        {
            con.Open();
            string query = "SELECT " + Col + " FROM " + tableName + " WHERE " + Col + " = @value";
            SqlCommand sqlcommand = new SqlCommand(query, con);
            sqlcommand.Parameters.AddWithValue("@Value", Value);
            SqlDataReader result = sqlcommand.ExecuteReader();
            var F = result.HasRows;
            con.Close();
            return F;
        }

        public static bool deleteRowDB(string tableName, string Col, string Value) 
        {

            int numberOfInsertedRows;
            try
            {
                con.Open();
                string query = "DELETE FROM " + tableName + " WHERE " + Col + " = '" + Value+"'";
                SqlCommand sqlcommand = new SqlCommand(query, con);
                numberOfInsertedRows = sqlcommand.ExecuteNonQuery();
                con.Close();
                return numberOfInsertedRows > 0;
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                con.Close();
                return false;
            }
        }

        public static string GetIntervalQuery(string ColName, string Min, string Max, string X)
        {
            if (Min == string.Empty && Max == string.Empty)
            {
                return "";
            }else if (Min != string.Empty && Max != string.Empty)
                {
                    return " AND "+ColName+" BETWEEN @Min"+X+" AND @Max"+X;
                }else if (Min != string.Empty)
                {
                    return " AND " + ColName + " >= @Min"+X;
                }else
                {
                 return " AND " + ColName + " <= @Max"+X;
                }
        }

    }
}
