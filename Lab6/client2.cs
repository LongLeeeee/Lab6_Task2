using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace Lab6
{
    public partial class client2 : Form
    {
        private System.Windows.Forms.Timer timer;
        StreamReader reader;
        StreamWriter writer;
        string username;
        int timeleft;
        public client2(StreamReader reader, StreamWriter writer, string username)
        {
            this.reader = reader;
            this.writer = writer;
            writer.AutoFlush = true;
            this.username = username;
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Countdown;
            name.Text = username;
            Thread receiveThread = new Thread(receive);
            receiveThread.Start();
            receiveThread.IsBackground = true;  
        }
        private void Countdown(object sender, EventArgs e)
        {
            if (timeleft > 0)
            {
                timeleft--;
                time.Text = $"00:{timeleft.ToString()}";
            }
            else
            {
                send.Visible = true;
            }
        }
        private void receive()
        {
            string receive = "";
            while (true)
            {
                receive = reader.ReadLine();
                if (receive == "Setup")
                {
                    Invoke(new Action(() =>
                    {
                        string[] numbers = reader.ReadLine().Split('|');
                        turn.Text = reader.ReadLine();
                        startNumber.Text = numbers[0];
                        endNumber.Text = numbers[1];
                    }));
                }
                else if (receive == "Finish")
                {
                    string winner = reader.ReadLine();

                    if (string.IsNullOrEmpty(winner))
                    {
                        Invoke(new Action(() =>
                        {
                            notifromServer.AppendText($"Không có người chiến thắng ở lượt {turn.Text}.\r\n");
                            notifromServer.AppendText($"\r\n");
                        }));
                        string fileName = $"history-{this.username}.txt";
                        string filepath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
                        StreamWriter writer = new StreamWriter(filepath, true);
                        writer.AutoFlush = true;
                        writer.WriteLine($"Không có người chiến thắng ở lượt {turn.Text}.\r\n\r\n");
                        writer.Close();
                    }
                    else
                    {
                        Invoke(new Action(() =>
                        {
                            notifromServer.AppendText($"Người chiến thắng ở lượt {turn.Text} là: {winner}\r\n");
                            notifromServer.AppendText($"\r\n");
                        }));
                        string fileName = $"history-{this.username}.txt";
                        string filepath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
                        StreamWriter writer = new StreamWriter(filepath, true);
                        writer.AutoFlush = true;
                        writer.WriteLine($"Người chiến thắng ở lượt {turn.Text} là: {winner}\r\n\r\n");
                        writer.Close();
                    }
                }
                else if (receive == "UpdatePoint")
                {
                    string point = reader.ReadLine();
                    Invoke(new Action(() =>
                    {
                        numbers.AppendText($"======================================\r\n");
                        numbers.AppendText($"Điểm của bạn sau lượt {turn.Text}: {point}\r\n\r\n");
                    }));
                    string fileName = $"history-{this.username}.txt";
                    string filepath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
                    StreamWriter writer = new StreamWriter(filepath, true);
                    writer.AutoFlush = true;
                    writer.WriteLine($"==========================================\r\n");
                    writer.WriteLine($"Điểm của bạn sau lượt {turn.Text}: {point}\r\n\r\n");
                    writer.Close();
                }
                else if (receive == "EndGame")
                {

                }
                else
                {
                    Invoke(new Action(() =>
                    {
                        time.Text = receive;
                    }));
                }
            }
        }

        private void send_Click(object sender, EventArgs e)
        {
            timeleft = 3;
            string sendString = $"{name.Text}|{answer.Text}";
            numbers.AppendText($"Số dự đoán: {answer.Text}\r\n");
            writer.WriteLine(sendString);
            timer.Start();
            if (timeleft != 0)
            {
                send.Visible = false; //ẩn buttom
                answer.Clear();
            }
            // Tạo file lưu người chơi
            string fileName = $"history-{this.username}.txt";
            string filepath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
            StreamWriter writer1 = new StreamWriter(filepath, true);
            writer1.AutoFlush = true;
            writer1.WriteLine($"Số dự đoán: {answer.Text}\r\n");
            writer1.Close();

        }

        private void answer_TextChanged(object sender, EventArgs e)
        {

        }

        private void client2_Load(object sender, EventArgs e)
        {

        }
    }
}
