using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class MAIN_FORM : Form
    {
    
        public MAIN_FORM()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            priority form1 = new priority();
            form1.Show();
            this.Hide();
        }



        private void add_Click(object sender, EventArgs e)
        {
           
           Form1 a = new Form1();
            a.Show();
            this.Hide();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
