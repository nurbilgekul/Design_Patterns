using Bridge.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bridge.Concrete
{
    class MSMQSender : IMessageSender
    {
        public void SendMessage(string subject, string body)
        {
            MessageBox.Show($"MSMQ\n{0}\n{1}\n, {subject},{body}");
        }
    }
}
