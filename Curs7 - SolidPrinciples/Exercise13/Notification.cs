using System.Collections.Generic;

namespace Exercise13
{
    internal class Notification
    {
        private ICollection<IMessage> _messages;

        public Notification(ICollection<IMessage> messages)
        {
            _messages = messages;
        }

        public void Send()
        {
            foreach (var message in _messages)
                message.SendMessage();
        }
    }
}
