using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClaseInterfaz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                       MessageBox.Show("gghghghhhj","", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Jji");
        }
    }
}
