using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP1
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            labelResult.Text = textName.Text;
            textName.Text = "";
        }
    }
}
