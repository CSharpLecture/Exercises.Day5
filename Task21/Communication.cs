using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;
using System.Windows.Forms;

namespace CsharpSolutions.Exercises.Task21
{
    public partial class Communication : Form
    {
        //Keep track of the thread
        Thread current;
        //and keep a reference to the synchronization context
        SynchronizationContext context;

        public Communication()
        {
            InitializeComponent();
            //Store the current synchronization context
            context = SynchronizationContext.Current;
        }

        void Worker(Object ip)
        {
            Ping ping = new Ping();

            while (true)
            {
                var reply = ping.Send((IPAddress)ip);

                //Use the sync. context for modifying the log
                context.Post(_ => log.AppendText(String.Format("Response from {0} in {1} ms with status {2}.{3}",
                    reply.Address.ToString(), reply.RoundtripTime.ToString(), reply.Status.ToString(), Environment.NewLine)), null);

                //Wait some time
                Thread.Sleep(1000);
            }
        }

        private void ping_Click(object sender, EventArgs e)
        {
            IPAddress address;

            //Try to parse the ip address
            if (IPAddress.TryParse(ip.Text, out address))
            {
                //Is there a current thread ? if so ... abort it!
                if (current != null)
                {
                    current.Abort();
                    current = null;
                }

                //Start a new one
                current = new Thread(Worker);
                current.Start(address);
            }
            else
                MessageBox.Show("The given IP address is invalid!");
        }
    }
}
