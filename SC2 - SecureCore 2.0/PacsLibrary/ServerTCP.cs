using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace PacsLibrary
{
    public class ServerTCP
    {
        //VARIABLES Y CONSTANTES
        int RecBytes;
        byte[] buffer;
        bool sortir = true;

        NetworkStream nwStreamServer;
        Thread th_Escuchar1, th_Escuchar2;
        TcpClient client;

        private int portChat = 8888;
        private int portData = 8889;
        public string dataName { get; set; }

        public void iniciarServer(RichTextBox txt_chat, int portChat, int portData, string dataName, Label labelState)
        {
            this.dataName = dataName;
            this.portData = portData; 
            this.portChat = portChat;

            th_Escuchar1 = new Thread(()=> { EscucharClienteMensaje(txt_chat); });
            th_Escuchar1.Start();
            th_Escuchar2 = new Thread(() => { EscucharClienteArchivo(labelState); });
            th_Escuchar2.Start();
        }

        public void apagarServer()
        {
            sortir = false;
        }

        //FUNCION PARA REINICIAR NO OPERATIVA
        private void reiniciarServer(int portChat, int portData, string dataName)
        {
            this.dataName = dataName;
            this.portData = portData;
            this.portChat = portChat;
        }

        private void EscucharClienteMensaje(RichTextBox txt_chat)
        {
            try
            {
                TcpListener listenerMsg = new TcpListener(IPAddress.Any, portChat);
                listenerMsg.Start();
                while (sortir)
                {
                    //ESPERA UN MENSAJE DE ENTRADA
                    if (listenerMsg.Pending())
                    {
                        //TRATAR MENSAJE DE ENTRADA
                        client = listenerMsg.AcceptTcpClient();
                        buffer = new byte[client.ReceiveBufferSize];
                        nwStreamServer = client.GetStream();
                        int bytesLength = nwStreamServer.Read(buffer, 0, client.ReceiveBufferSize);
                        string _dataRecived = Encoding.ASCII.GetString(buffer);

                        //DEVOLVER UNA RESPUESTA
                        RespuestaCliente("Respuesta recibida");

                        txt_chat.Invoke((MethodInvoker)delegate
                        {
                            txt_chat.Text +=  Environment.NewLine + "[Mensaje Nave]     ➖ " + _dataRecived;
                        });

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EscucharClienteArchivo(Label labelState)
        {
            try
            {
                TcpListener listenerData = new TcpListener(IPAddress.Any, portData);
                listenerData.Start();
                while (sortir)
                {
                    //ESPERA UN ARCHIVO DE ENTRADA
                    if (listenerData.Pending())
                    {
                        client = listenerData.AcceptTcpClient();
                        nwStreamServer = client.GetStream();
                        buffer = new byte[client.ReceiveBufferSize];

                        string SaveFileName = @"C:\Users\admin\Desktop\ArcivosRecibidos\" + dataName;

                        int totalrecbytes = 0;
                        FileStream Fs = new FileStream(SaveFileName, FileMode.OpenOrCreate, FileAccess.Write);
                        while ((RecBytes = nwStreamServer.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            Fs.Write(buffer, 0, RecBytes);
                            totalrecbytes += RecBytes;
                        }

                        //DEVOLVER UNA RESPUESTA
                        labelState.Invoke((MethodInvoker)delegate
                        {
                            labelState.Text = "Respuesta recibida";
                        });

                        Fs.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RespuestaCliente(string respuesta)
        {
            try
            {
                byte[] nouBuffer = Encoding.ASCII.GetBytes(respuesta);
                nwStreamServer.Write(nouBuffer, 0, nouBuffer.Length);
                nwStreamServer.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
