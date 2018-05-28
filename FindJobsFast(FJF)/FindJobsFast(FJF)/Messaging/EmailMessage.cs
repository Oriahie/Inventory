using System;

namespace FindJobsFast_FJF_.Messaging
{
    public class EmailMessage
    {
        public String Subject { get; set; }
        public String From { get; set; }
        public String Recipient { get; set; }
        public String Body { get; set; }
        
    }
}