using System;
using System.Collections.Generic;
using System.Text;

namespace GmailAplication
{
    internal class EmailFormat
    {
        public string Reciptient { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }

        public string Format()
        {
            return $"To: {Reciptient} - {Subject}";
        }
        
    }
}
