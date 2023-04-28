namespace Example13
{
    internal class Notification
    {
        private Email _email;
        private Sms _sms;

        public Notification()
        {
            _email = new Email();
            _sms = new Sms();
        }

        public void Send()
        {
            _email.SendEmail();
            _sms.SendSms();
        }
    }
}
