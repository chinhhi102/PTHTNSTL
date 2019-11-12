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
    public partial class hosokhongtrungtuyen : Form
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
            dtgvHSKTT.DataSource = table;
        }
        public hosokhongtrungtuyen()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MainForm.ActiveForm.Close();
        }
    }
}
