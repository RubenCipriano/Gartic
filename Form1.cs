using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Net.Sockets;
using System.Net;

namespace Gartic
{
    public partial class Form1 : Form
    {
      byte[] byteData = new byte[1024];
        public Socket clientSocket; //Socket do cliente
        public string strName;      //Nome do utilizador no chat
        public EndPoint epServer;   //IP do servidor
        public bool joga;
        int OLA = 1;
        Graphics g;
        int x = -1;
        int y = -1;
        Pen pen;
        Data msgReceived;
        bool moving= false;
        string acertou = null;
        public Form1()
        {
            InitializeComponent();
            g = pnDesenhar.CreateGraphics();
            pen = new Pen(Color.Black,5);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }
        string palavra;
        

        private void Form1_Load(object sender, EventArgs e)
        {

            progressBar1.Value = 100;
            lsbUsers.Items.Add(strName);
            lsbUsers.Items.Add("Pontos: " + pontos);
            palavra = "banana";
            clientSocket.BeginReceiveFrom(byteData, 0, byteData.Length, SocketFlags.None, ref epServer, new AsyncCallback(onReceive), epServer);
        }
        private void onReceive(IAsyncResult ar)
        {
            try
            {
                clientSocket.EndReceiveFrom(ar, ref epServer);
                msgReceived = new Data(byteData);
                switch(msgReceived.cmdCommand)
                {
                    case Command.Null:
                        if (msgReceived.strMessage == "Joga" && msgReceived.strName == strName)
                            pnDesenhar.Enabled = true;
                        else
                            pnDesenhar.Enabled = false;
                        break;
                    case Command.Prog:
                        progressBar1.Value = Convert.ToInt32(msgReceived.strMessage);
                        break;
                    case Command.Paint:

                }
                
            }
            catch
            { }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            pen.Color = p.BackColor;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            x= e.X;
            y = e.Y;
            pnDesenhar.Cursor = Cursors.Cross;

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            x = -1;
            y = -1;
            pnDesenhar.Cursor = Cursors.Default;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            progressBar1.Step -= 1;
            if(moving && x!=-1 && y!= -1)
            {
                g.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;

                msgReceived = new Data();
                msgReceived.strName = x + "*" + y;
                msgReceived.strMessage = pen.Color.ToString();
                msgReceived.cmdCommand = Command.Null;
                byte[] byteData = msgReceived.ToByte();

                clientSocket.BeginSendTo(byteData, 0, byteData.Length, SocketFlags.None, epServer, new AsyncCallback(OnSend), null);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            pen.Color = p.BackColor;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            pen.Color = p.BackColor;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            pen.Color = p.BackColor;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            pen.Color = p.BackColor;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            if (OLA == 1)
            {
                pnDesenhar.BackColor = Color.Snow;
                OLA = 0;
            }
            else
            {
                pnDesenhar.BackColor = Color.White;
                OLA = 1;
            }
        }
        int pontos = 0;
        private void btnSend_Click(object sender, EventArgs e)
        {
            string mensagem = null;
            if (txtEnviar.Text == "")
                return;
            mensagem = strName + " : " + txtEnviar.Text;
            lsbConversa.Items.Add(mensagem);


            if (txtEnviar.Text == palavra)
            {
                pontos++;
                palavra = "Ruben";

                for (int idx = 0; idx < lsbUsers.Items.Count - 1; idx++)
                {
                    if (lsbUsers.Items[idx] == strName)
                    {
                        lsbUsers.Items[idx + 1] = "Pontos: " + pontos;

                    }
                }
            }


            try
            {
                msgReceived = new Data();
                msgReceived.strName = strName;
                msgReceived.strMessage = txtEnviar.Text;
                msgReceived.cmdCommand = Command.Message;
                byte[] byteData = msgReceived.ToByte();

                clientSocket.BeginSendTo(byteData, 0, byteData.Length, SocketFlags.None, epServer, new AsyncCallback(OnSend), null);
            }
            catch
            {
                MessageBox.Show("Erro!");
            }
            txtEnviar.Text = "";
        }
       private void OnSend(IAsyncResult ar)
        {
            try
            {
                clientSocket.EndSend(ar);
            }
            catch
            { }
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
          
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            clientSocket.BeginReceiveFrom(byteData, 0, byteData.Length, SocketFlags.None, ref epServer, new AsyncCallback(onReceive), null);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            msgReceived = new Data();
            msgReceived.strName = strName;
            msgReceived.strMessage = txtEnviar.Text;
            msgReceived.cmdCommand = Command.Logout;
            byte[] byteData = msgReceived.ToByte();

            clientSocket.BeginSendTo(byteData, 0, byteData.Length, SocketFlags.None, epServer, new AsyncCallback(OnSend), null);
        }
    }
   
}
