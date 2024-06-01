using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Lab6
{
    public partial class server : Form
    {
        TcpListener tcpListener;
        bool isRunning = false;
        TcpClient tcpClient;
        StreamReader reader;
        int totalPlayer = 0;
        Dictionary<string, TcpClient> playerList;
        Dictionary<string, int> pointList;
        List<string> playerNames;
        List<string> playerAnswers;
        StreamWriter writer;
        private System.Windows.Forms.Timer timer;
        private int timeleft;
        bool isStarted = false;
        int numberToSearch = -1;
        int Turn = 0;
        int randomNumber1;
        int randomNumber2;
        string winner;
        public server()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Countdown;
            isRunning = true;
            Thread serverThread = new Thread(listen);
            serverThread.Start();
            serverThread.IsBackground = true;
        }
        private async void listen()
        {
            playerList = new Dictionary<string, TcpClient>();
            IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            tcpListener = new TcpListener(iPEndPoint);
            tcpListener.Start();
            playerAnswers = new List<string>();
            playerNames = new List<string>();
            pointList = new Dictionary<string, int>();
            while (isRunning)
            {
                tcpClient = tcpListener.AcceptTcpClient();

                int i = 1;
                Invoke(new Action(() =>
                {
                    i = 1;
                    rank.Clear();
                }));
                totalPlayer++;
                writer = new StreamWriter(tcpClient.GetStream());
                writer.AutoFlush = true;
                reader = new StreamReader(tcpClient.GetStream());
                string nameOfPlayer = reader.ReadLine();
                playerList.Add(nameOfPlayer, tcpClient);
                pointList.Add(nameOfPlayer, 0);
                Invoke(new Action(() =>
                {
                    Clients.AppendText($"{nameOfPlayer}: {DateTime.Now}\r\n");
                    numberOfClient.Text = totalPlayer.ToString();
                    var sortedDictionary = pointList.OrderByDescending(pair => pair.Value).ToDictionary(pair => pair.Key, pair => pair.Value);
                    foreach (var item in sortedDictionary)
                    {
                        rank.AppendText($"{i}. {item.Key}: {item.Value}\r\n");
                        i++;
                    }
                }));
                byte[] postData = Encoding.UTF8.GetBytes($"{nameOfPlayer}: {DateTime.Now}\r\n");
                WebRequest webRequest = WebRequest.Create("https://ctxt.io");
                webRequest.Method = "POST";
                webRequest.ContentType = "application/json";
                webRequest.ContentLength = postData.Length;

                Stream dataStream = webRequest.GetRequestStream();
                dataStream.Write(postData, 0, postData.Length);

                Thread thread = new Thread(() => handle(nameOfPlayer));
                thread.Start();
                thread.IsBackground = true;
            }
        }
        private void Countdown(object sender, EventArgs e)
        {
            if (timeleft >= 0)
            {
                if (timeleft != -1)
                {
                    timeleft--;
                    if (timeleft < 10)
                    {
                        time.Text = $"00:0{timeleft.ToString()}";
                    }
                    else
                    {
                        time.Text = $"00:{timeleft.ToString()}";
                    }
                }
            }
            
        }
        private void start_Click(object sender, EventArgs e)
        {
            randomNumber();
            Turn = 1;
            lb_answer.Text = numberToSearch.ToString();
            turn.Text = Turn.ToString();
            string scope = $"{randomNumber1.ToString()}|{randomNumber2.ToString()}";
            foreach (var item in playerList)
            {
                StreamWriter wr = new StreamWriter(item.Value.GetStream());
                wr.AutoFlush = true;
                wr.WriteLine("Setup");
                wr.WriteLine(scope);
                wr.WriteLine(Turn.ToString());
            }
            timeleft = 60;
            time.Text = "01:00";
            timer.Start();

            Thread thread2 = new Thread(sendTime);
            thread2.Start();
            thread2.IsBackground = true;
        }
        private void sendTime()
        {
            while (Turn < 6)
            {
                if (timeleft >= 0)
                {
                    foreach (var item in playerList)
                    {
                        StreamWriter wr = new StreamWriter(item.Value.GetStream());
                        wr.AutoFlush = true;
                        wr.WriteLine(time.Text);
                    }
                }
                else
                {
                    Invoke(new Action(() =>
                    {
                        timer.Stop();
                        notification.AppendText("==================================================\r\n");
                        notification.AppendText("======================== Kết Quả ======================\r\n");
                        lb_answer.Text = numberToSearch.ToString();
                        notification.AppendText($"Số cần tìm là: {lb_answer.Text}\r\n");

                        if (playerAnswers.Contains(numberToSearch.ToString()))
                        {
                            int index = playerAnswers.IndexOf(numberToSearch.ToString());
                            notification.AppendText($"Người chiến thắng ở lượt {turn.Text} là: {playerNames[index]}\r\n");
                            pointList[playerNames[index]] += 10;
                            winner = playerNames[index];
                            foreach(var item in playerNames)
                            {
                                if (item != winner && pointList[item] > 0)
                                {
                                    pointList[item] -= 5;
                                }
                            }
                            int i = 1;
                            rank.Clear();
                            var sortedDictionary = pointList.OrderByDescending(pair => pair.Value).ToDictionary(pair => pair.Key, pair => pair.Value);
                            foreach (var item in sortedDictionary)
                            {
                                StreamWriter wr = new StreamWriter(playerList[item.Key].GetStream());
                                wr.AutoFlush = true;
                                wr.WriteLine("UpdatePoint");
                                wr.WriteLine(item.Value.ToString());
                                rank.AppendText($"{i}. {item.Key}: {item.Value}\r\n");
                                i++;
                            }
                        }
                        else
                        {
                            notification.AppendText($"Không có người chiến thắng ở lượt {turn.Text}.\r\n");
                            winner = "";
                            foreach(var item in playerNames)
                            {
                                if (pointList[item] > 0)
                                {
                                    pointList[item] -= 5;
                                }
                            }
                            int i = 1;
                            rank.Clear();
                            var sortedDictionary = pointList.OrderByDescending(pair => pair.Value).ToDictionary(pair => pair.Key, pair => pair.Value);
                            foreach (var item in sortedDictionary)
                            {
                                StreamWriter wr = new StreamWriter(playerList[item.Key].GetStream());
                                wr.AutoFlush = true;
                                wr.WriteLine("UpdatePoint");
                                wr.WriteLine(item.Value.ToString());
                                rank.AppendText($"{i}. {item.Key}: {item.Value}\r\n");
                                i++;
                            }
                            winner = "";
                        }
                        foreach (var item in playerList)
                        {
                            StreamWriter wr = new StreamWriter(item.Value.GetStream());
                            wr.AutoFlush = true;
                            wr.WriteLine("Finish");
                            wr.WriteLine(winner);
                            
                        }
                        randomNumber();
                        Turn++;
                        lb_answer.Text = numberToSearch.ToString();
                        turn.Text = Turn.ToString();
                        string scope = $"{randomNumber1.ToString()}|{randomNumber2.ToString()}";
                        foreach (var item in playerList)
                        {
                            StreamWriter wr = new StreamWriter(item.Value.GetStream());
                            wr.AutoFlush = true;
                            wr.WriteLine("Setup");
                            wr.WriteLine(scope);
                            wr.WriteLine(Turn.ToString());
                        }
                        lb_answer.Text = numberToSearch.ToString();
                        turn.Text = Turn.ToString();
                        time.Text = "01:00";
                        timeleft = 10;
                        timer.Start();
                    }));
                }
            }
            writer.WriteLine("EndGame");
        }
        private void randomNumber()
        {
            Invoke(new Action(() =>
            {
                var random = new Random();
                randomNumber1 = random.Next(0, 50);
                randomNumber2 = random.Next(randomNumber1, 100);
                startNumber.Text = randomNumber1.ToString();
                endNumber.Text = randomNumber2.ToString();
                numberToSearch = random.Next(randomNumber1, randomNumber2);
            }));
        }
        public void handle(string username)
        {
            StreamReader reader1 = new StreamReader(playerList[username].GetStream());
            while (true)
            {
                string rqFromClient = reader1.ReadLine();
                string playerName = rqFromClient.Substring(0, rqFromClient.IndexOf("|"));
                string answer = rqFromClient.Substring(rqFromClient.IndexOf("|") + 1);
                Invoke(new Action(() =>
                {
                    notification.AppendText($"{playerName}: {answer} ({time.Text}) \r\n");
                }));
                playerNames.Add(playerName);
                playerAnswers.Add(answer);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void server_Load(object sender, EventArgs e)
        {

        }
    }
}
