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
    public partial class AddGoods : Form
    {
        Connection con;
        SqlQueries sqlQue;
        DataSet ds;

        public AddGoods()
        {
            InitializeComponent();
        }

        // wczytawanie danych
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

        // uzupelnienie pol na formie
        private void AddGoods_Load(object sender, EventArgs e)
        {
            con = new Connection();
            sqlQue = new SqlQueries();
            loadFromMDBFile();

            dataGridView.DataSource = sqlQue.custom_que("SELECT * FROM `store`", "store");
            dataGridView.DataMember = "store";

            for (int i = 0; i < dataGridView.RowCount - 1; i++)
                comboGPU.Items.Add(dataGridView.Rows[i].Cells[0].Value.ToString());
        }

        // zdarzenie po kliknieciu add - dodanie nowego wpisu do bazy
        private void add_Click(object sender, EventArgs e)
        {
            int new_quantity = 0;

            for (int i = 0; i < dataGridView.RowCount - 1; i++)
                if (dataGridView.Rows[i].Cells[0].Value.ToString() == comboGPU.Text)
                    new_quantity = int.Parse(dataGridView.Rows[i].Cells[2].Value.ToString()) + int.Parse(textBox.Text);

            sqlQue.update("store", "quantity", new_quantity.ToString(), "gpu_name", comboGPU.SelectedItem.ToString());
        }

        // zamkniecie formy
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
