using DesignPattern.Decorator.DAL;
using System;

namespace DesignPattern.Decorator.DecoratorPattern2
{
    public class EncryptByContentDecorator : Decorator
    {
        private readonly ISendMessage _sendMessage;
        Context context = new Context();
        public EncryptByContentDecorator(ISendMessage sendMessage) : base(sendMessage)
        {
            _sendMessage = sendMessage;
        }

        public void SendMessageEncryptByContent(Message message)
        {
            message.MessageSender = "Team Leader";
            message.MessageReceiver = "Developer Team";
            message.MessageContent = "The meeting will be held at 17 o'clock";
            message.MessageSubject = "Meeting";
            string data = "";
            data = message.MessageContent;
            char[] chars = data.ToCharArray();
            foreach (char c in chars)
            {
                message.MessageContent += Convert.ToChar(c + 3).ToString();
            }
            context.Messages.Add(message);
            context.SaveChanges();
        }

        public override void SendMessage(Message message)
        {
            base.SendMessage(message);
            SendMessageEncryptByContent(message);
        }
    }
}
