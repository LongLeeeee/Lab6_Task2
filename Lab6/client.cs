using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class client : Form
    {
        public client()
        {
            InitializeComponent();
        }
        TcpClient tcpClient;
        StreamReader reader;
        StreamWriter writer;
        private void client_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tcpClient = new TcpClient();
            try
            {
                tcpClient.Connect(IPAddress.Parse("127.0.0.1"), 8080);

            }
            catch
            {
                MessageBox.Show("Sever isn't running!");
                return;
            }
            reader = new StreamReader(tcpClient.GetStream());
            writer = new StreamWriter(tcpClient.GetStream());
            writer.AutoFlush = true;
            writer.WriteLine(name.Text);
            client2 client2 = new client2(reader, writer, name.Text);
            client2.Show();
            this.Hide();
        }
    }
}
