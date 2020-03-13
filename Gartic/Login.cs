using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Gartic
{
    enum Command
    {
        Login,      //Entrada/conectar
        Logout,     //Saída/desconectar
        Message,    //Envio de mensagem para todos os clientes
        List,       //Obter lista dos utilizadores
        Null,        //auxiliar
        Prog,
        Paint
    }
    public partial class Login : Form
    {
        byte[] byteData = new byte[1024];
        public Socket clientSocket;
        public EndPoint epServer;
        public string strName;
        public bool joga;
        Data msgReceived;

        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            strName = txtName.Text;
            try
            {
                //Utilizar Socket UDP
                clientSocket = new Socket(AddressFamily.InterNetwork,
                    SocketType.Dgram, ProtocolType.Udp);

                //Endereço IP do servidor
                IPAddress ipAddress = IPAddress.Parse(txtServerIP.Text);
                //Servidor a aguardar comunicação na porta 1100
                IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, 1000);

                epServer = (EndPoint)ipEndPoint;

                Data msgToSend = new Data();
                msgToSend.cmdCommand = Command.Login;
                msgToSend.strMessage = null;
                msgToSend.strName = strName;

                byte[] byteData = msgToSend.ToByte();

                //Login
                clientSocket.BeginSendTo(byteData, 0, byteData.Length,
                    SocketFlags.None, epServer, new AsyncCallback(OnSend), null);
            }   
            catch (ObjectDisposedException)
            { }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cliente",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
    }
        
        private void OnSend(IAsyncResult ar)
        {
            clientSocket.EndSend(ar);
            strName = txtName.Text;
            DialogResult = DialogResult.OK;
            Form1 Formm = new Form1();
            Formm.clientSocket = clientSocket;
            Formm.strName = strName;
            Formm.epServer = epServer;
            //Formm.ShowDialog();
            Close();
        }
       
        /* private void OnSend(IAsyncResult ar)
        {
            try
            {
                clientSocket.EndSend(ar);
                strName = txtName.Text;
                DialogResult = DialogResult.OK;
                Form1 Formm = new Form1();
                Formm.clientSocket = clientSocket;
                Formm.strName = strName;
                Formm.epServer = epServer;

                Formm.ShowDialog();
               // Close();
            }
            catch(ObjectDisposedException)
            { }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } */
    }
    class Data
    {
        public Data()
        {
            this.cmdCommand = Command.Null;
            this.strMessage = null;
            this.strName = null;
        }

        //Converte os bytes num objecto do tipo Data
        public Data(byte[] data)
        {
            //4 bytes para o comando
            this.cmdCommand = (Command)BitConverter.ToInt32(data, 0);

            //5-8 segundos bytes para o nome
            int nameLen = BitConverter.ToInt32(data, 4);

            //9-12 para a mensagem
            int msgLen = BitConverter.ToInt32(data, 8);

            //Garantir que a string strName passou para o array de bytes
            if (nameLen > 0)
                this.strName = Encoding.UTF8.GetString(data, 12, nameLen);
            else
                this.strName = null;

            //Verificar se a mensagem tem conteúdo
            if (msgLen > 0)
                this.strMessage = Encoding.UTF8.GetString(data, 12 + nameLen, msgLen);
            else
                this.strMessage = null;
        }

        //Converter a estrutura de dados num array de bytes
        public byte[] ToByte()
        {
            List<byte> result = new List<byte>();

            //primeiros 4 bytes para o comando
            result.AddRange(BitConverter.GetBytes((int)cmdCommand));

            //adicionar o nome
            if (strName != null)
                result.AddRange(BitConverter.GetBytes(strName.Length));
            else
                result.AddRange(BitConverter.GetBytes(0));

            //adicionar mensagem
            if (strMessage != null)
                result.AddRange(BitConverter.GetBytes(strMessage.Length));
            else
                result.AddRange(BitConverter.GetBytes(0));

            if (strName != null)
                result.AddRange(Encoding.UTF8.GetBytes(strName));

            //adicionar a mensagem
            if (strMessage != null)
                result.AddRange(Encoding.UTF8.GetBytes(strMessage));

            return result.ToArray();
        }

        public string strName;      //Nome do cliente no Chat
        public string strMessage;   //Messagem
        public Command cmdCommand;  //Tipo de comando (login, logout, send message, ...)
    }
}
