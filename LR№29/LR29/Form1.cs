using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
namespace LR29
{
    public partial class Form1 : Form
    {
        bool alive = false;
        bool isFileCreated = false;
        UdpClient client;
        const int LOCALPORT = 8001; 
        const int REMOTEPORT = 8001; 
        const int TTL = 20;
        const string HOST = "235.5.5.1"; 
        IPAddress groupAddress; 
        string userName; 
        public Form1()
        {
            InitializeComponent();
            loginBtn.Enabled = true; 
            exitBtn.Enabled = false; 
            sendBtn.Enabled = false; 
            chatBox.ReadOnly = true; 
            groupAddress = IPAddress.Parse(HOST);

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (alive)
                ExitChat();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            userName = userNameBox.Text;
            userNameBox.ReadOnly = true;
            try
            {
                client = new UdpClient(LOCALPORT);
                //підєднання до групового розсилання
                client.JoinMulticastGroup(groupAddress, TTL);

                // задача на приймання повідомлень
                Task receiveTask = new Task(ReceiveMessages);
                receiveTask.Start();
                // перше повідомлення про вхід нового користувача
                string message = userName + " вошел в чат";
                byte[] data = Encoding.Unicode.GetBytes(message);
                client.Send(data, data.Length, HOST, REMOTEPORT);
                loginBtn.Enabled = false;
                exitBtn.Enabled = true;
                sendBtn.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void ReceiveMessages()
        {
            alive = true;
            try
            {
                while (alive)
                {
                    IPEndPoint remoteIp = null;
                    byte[] data = client.Receive(ref remoteIp);
                    string message = Encoding.Unicode.GetString(data);
                    // добавляем полученное сообщение в текстовое поле
                    this.Invoke(new MethodInvoker(() =>
                    {
                        string time = DateTime.Now.ToShortTimeString();
                        chatBox.Text = time + " " + message + "\r\n"
                        + chatBox.Text;
                    }));
                }
            }
            catch (ObjectDisposedException)
            {
                if (!alive)
                    return;
                throw;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string message = String.Format("{0}: {1}", userName,
               messageBox.Text);
                byte[] data = Encoding.Unicode.GetBytes(message);
                client.Send(data, data.Length, HOST, REMOTEPORT);
                messageBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            ExitChat();
        }
        private void ExitChat()
        {
            string message = userName + " покидает чат";
            byte[] data = Encoding.Unicode.GetBytes(message);
            client.Send(data, data.Length, HOST, REMOTEPORT);
            client.DropMulticastGroup(groupAddress);
            alive = false;
            client.Close();
            loginBtn.Enabled = true;
            exitBtn.Enabled = false;
            sendBtn.Enabled = false;
        }
        private void saveChat()
        {
            string[] lines = chatBox.Lines;
            if (isFileCreated == false)
            {
                using (StreamWriter sw = File.CreateText("D:\\Games\\c++\\LR29\\LR29\\chatLog.txt"));
                isFileCreated = true;
            } 
            using (var writer = new StreamWriter("D:\\Games\\c++\\LR29\\LR29\\chatLog.txt", true))
            {
                foreach(string line in lines)
                {
                    writer.WriteLine(line);
                }
            }
        }

        private void saveChatBtn_Click(object sender, EventArgs e)
        {
            saveChat();
        }
    }
}