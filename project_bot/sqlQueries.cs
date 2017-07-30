using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_bot
{
    // klasa dla realizacji kwerend oraz zmian do bazy danych. 
    public class SqlQueries
    {
        OleDbConnection con;        // zwiazek z pkiem bazy
        OleDbDataAdapter ad;        // adapter dla dostepu do danych

        // metoday dla wprowadzania wlasnej kwerendy (recznie)
        public DataSet custom_que(String query, String TableName)
        {
            con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\database.mdb;");

            ad = new OleDbDataAdapter(query, con);
            DataSet ds = new DataSet();

            try
            {
                ad.Fill(ds, TableName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return ds;
        }

        // dodanie dobazy nowego wpisu
        public void add(string TableName, string ColumnsNames, string NewData)
        {
            string Insert = "INSERT INTO `" + TableName + "` ( " + ColumnsNames + " ) VALUES ( " + NewData + ")";
            OleDbDataAdapter ad = new OleDbDataAdapter("SELECT * FROM " + TableName + "", con);

            MessageBox.Show(Insert);

            ad.InsertCommand = new OleDbCommand(Insert, con);

            try
            {
                con.Open();
                ad.InsertCommand.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }
        }

        // aktuakizacja danych w istniejacym wpisie
        public void update(String TableName, String ColumnName, String TextInCell, String IDColumn, String CellText)
        {
            OleDbDataAdapter ad = new OleDbDataAdapter("SELECT * FROM " + TableName + "", con);
            string Change = "UPDATE `" + TableName + "` SET `" + ColumnName + "` = '" + TextInCell + "' WHERE `" + IDColumn + "` = '" + CellText + "'";

            ad.UpdateCommand = new OleDbCommand(Change, con);

            try
            {
                con.Open();
                ad.UpdateCommand.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }
        }
    }
}
