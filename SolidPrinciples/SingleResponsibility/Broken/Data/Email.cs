namespace SolidPrinciples.SingleResponsibility.Broken.Data
{
    internal class Email
    {
        public string ToAddress { get; set; }
        public string FromAddress { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
