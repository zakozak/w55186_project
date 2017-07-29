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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void showStoreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Store store = new Store();
            store.MdiParent = this;
            store.Show();
        }

        private void showOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            orders.MdiParent = this;
            orders.Show();
        }

        private void addOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddOrder add_orders = new AddOrder();
            add_orders.MdiParent = this;
            add_orders.Show();
        }

        private void addToStoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddGoods add_g = new AddGoods();
            add_g.MdiParent = this;
            add_g.Show();
        }

        private void deleteFromStoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteGoods delete_g = new DeleteGoods();
            delete_g.MdiParent = this;
            delete_g.Show();
        }
    }
}
