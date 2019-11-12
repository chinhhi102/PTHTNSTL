using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Chucnang3
{
    public partial class ketquakiemtra : Form
    {

        SqlConnection connection;
        SqlCommand command;
        string str = "link co so du lieu nha";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "cau truy van";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dtgvKQKT1.DataSource = table;
            dtgvKQKT2.DataSource = table;
        }
        public ketquakiemtra()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainForm.ActiveForm.Close();
        }
    }
}
