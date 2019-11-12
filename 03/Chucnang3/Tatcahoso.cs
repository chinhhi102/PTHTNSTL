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
    public partial class Tatcahoso : Form
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
            dtgvTCHS.DataSource = table;
        }
        public Tatcahoso()
        {
            InitializeComponent();
            
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainForm.ActiveForm.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            themhoso frmthemhoso = new themhoso();
            frmthemhoso.ShowDialog();
        }
    }
}
