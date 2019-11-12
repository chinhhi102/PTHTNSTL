using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Chucnang3
{
    public partial class hosotrungtuyen : Form
    {
        public hosotrungtuyen()
        {
            InitializeComponent();
        }

        private void hosotrungtuyen_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = XLDL.GetData("select * from KHACHHANG");
            dataGridView1.DataBindings.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
     
    }
}
