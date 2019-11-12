using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chucnang3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toànBộHồSơToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tatcahoso frmtatcahoso = new Tatcahoso();
            frmtatcahoso.ShowDialog();
        }

        private void hồSơTrúngTuyểnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hosotrungtuyen frmhosotrungtuyen = new hosotrungtuyen();
            frmhosotrungtuyen.Show();
        }

        private void hồSơKhôngTrúngTruyểnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hosokhongtrungtuyen frmhosokhongtrungtuyen = new hosokhongtrungtuyen();
            frmhosokhongtrungtuyen.Show();
        }

        private void kiểmTraKếtQuảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ketquakiemtra frmketquakiemtra = new ketquakiemtra();
            frmketquakiemtra.Show();
        }
    }
}
