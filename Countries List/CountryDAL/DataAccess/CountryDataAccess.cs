﻿using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CountryDAL.DataAccess
{
    public class CountryDataAccess
    {

        private string cs = ConfigurationManager.ConnectionStrings[""].ConnectionString;

        //return all country
        DataSet dataset { get; set; }
        public DataSet returnCountry()
        {

            dataset = new DataSet();
            using (SqlConnection con = new SqlConnection(cs))
            {

                SqlCommand cmd = new SqlCommand("", con);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter dataadapter = new SqlDataAdapter(cmd);

                dataadapter.Fill(dataset);

                return dataset;
            }

        }
        //return country by id
        public DataSet returnCountry(int id)
        {

            dataset = new DataSet();
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("", con);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter("", id);  
                cmd.Parameters.Add(param);               

                SqlDataAdapter dataadapter = new SqlDataAdapter(cmd);

                dataadapter.Fill(dataset);

                return dataset;
            }

        }
    }
}
