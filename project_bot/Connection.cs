﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_bot
{
    /// <summary>
    /// klasa dla podlacznia do pliku bazy na komputerze
    /// </summary>
    public class Connection
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\database.mdb;");

        public Connection() { }

        /// <summary>
        /// filling data apadter
        /// </summary>
        /// <param name="table_name"></param>
        /// <returns></returns>
        public OleDbDataAdapter fillDataWeGetBefore(String table_name)
        {
            OleDbCommand com = new OleDbCommand("SELECT * FROM " + table_name, con);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(com);

            return dataAdapter;
        }

        /// <summary>
        /// filling data set
        /// </summary>
        /// <returns></returns>
        public DataSet fillDataSet()
        {
            con.Close();
            con.Open();

            DataSet ds = new DataSet();
            ds.Tables.Clear();
            ds.Tables.Add(con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" }));

            return ds;
        }

        /// <summary>
        /// filling data table
        /// </summary>
        /// <returns></returns>
        public DataTable loadDataBase()
        {
            DataTable t1 = null;

            try
            {
                DataSet ds = fillDataSet();

                foreach (DataRow r in ds.Tables[0].Rows)
                {
                    t1 = con.GetOleDbSchemaTable(OleDbSchemaGuid.Columns,
                        new object[] { null, null, r["TABLE_NAME"], null });
                }
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }

            return t1;
        }
    }
}
