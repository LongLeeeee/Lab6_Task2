using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void server_Click(object sender, EventArgs e)
        {
            server sv = new server();
            sv.Show();
            server.Visible = false;
        }

        private void client_Click(object sender, EventArgs e)
        {
            client cli = new client();  
            cli.Show();
        }
    }
}
