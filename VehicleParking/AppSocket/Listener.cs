using System;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace VehicleParking.AppSocket
{
    class Listener
    {
        private Socket _socket;

        public bool Listening { get; private set; }

        public int Port { get; private set; }

        public Listener(int port)
        {
            Port = port;
          
            
            _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
           
        }

        public void Start()
        {
            if (Listening) return;
            try
            {
                var ep = new IPEndPoint(IPAddress.Parse("192.168.0.2"), Port);
                _socket.Bind(ep);
                _socket.Listen(0);
                _socket.BeginAccept(Callback, null);
                Listening = true;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
           
        }

        public void Stop()
        {
            if (!Listening) return;
            if (_socket.Connected)
            _socket.Shutdown(SocketShutdown.Both);
            _socket.Close();
            _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public delegate void SocketAcceptedHandler(Socket e);
        public event SocketAcceptedHandler SocketAccepted;
        void Callback(IAsyncResult ar)
        {
            try
            {
                var s = _socket.EndAccept(ar);
                if (SocketAccepted != null) SocketAccepted(s);
                _socket.BeginAccept(Callback, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}