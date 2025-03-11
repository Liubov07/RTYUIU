using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Учёт_студентов
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 ff = new Form5();
            ff.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 ff = new Form2();
            ff.Show();
            this.Hide();

        }
    }
}
