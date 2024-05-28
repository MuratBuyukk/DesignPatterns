using DesignPattern.Decorator.DAL;
using System;

namespace DesignPattern.Decorator.DecoratorPattern2
{
    public class EncryptBySubjectDecorator : Decorator
    {
        private readonly ISendMessage _sendMessage;
        Context context = new Context();
        public EncryptBySubjectDecorator(ISendMessage sendMessage) : base(sendMessage)
        {
            _sendMessage = sendMessage;
        }

        public void SendMessageEncryptBySubject(Message message)
        {
            string data = message.MessageSubject;
            char[] chars = data.ToCharArray();
            message.MessageSubject = " ";
            foreach (char c in chars)
            {
                message.MessageSubject += Convert.ToChar(c+3).ToString();
            }
            context.Messages.Add(message);
            context.SaveChanges();
        }

        public override void SendMessage(Message message)
        {
            base.SendMessage(message);
            SendMessageEncryptBySubject(message);
        }
    }
}
