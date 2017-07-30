using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_bot
{
    public partial class Orders : Form
    {
        Connection con;
        SqlQueries sqlQue;
        DataSet ds;

        public Orders()
        {
            InitializeComponent();
        }

        // wprowadzanie danych przy uruchomieniu programu
        private void Orders_Load(object sender, EventArgs e)
        {
            con = new Connection();
            sqlQue = new SqlQueries();
            loadFromMDBFile();

            dataGridView.DataSource = sqlQue.custom_que("SELECT * FROM `orders`", "orders");
            dataGridView.DataMember = "orders";
        }

        // wczytywanie danych
        public void loadFromMDBFile()
        {
            ds = con.fillDataSet();
            DataTable t;

            foreach (DataRow r in ds.Tables[0].Rows)
            {
                t = con.loadDataBase();
                t.TableName = r["TABLE_NAME"].ToString();
                OleDbDataAdapter ad = con.fillDataWeGetBefore(r["TABLE_NAME"].ToString());
                ad.Fill(ds, r["TABLE_NAME"].ToString());
            }
        }

        // wyswietlic wszystkie zamownienia
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = sqlQue.custom_que("SELECT * FROM `orders`", "orders");
            dataGridView.DataMember = "orders";
        }
    }
}
