using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;


namespace WebApiAuthorization.Models
{
    public partial class Chatroom
    {    
        public string LastMessage
        {
            get
            {
                string message = "No";
                try
                {
                    message = ChatMessage.LastOrDefault()?.TextMessage ?? "No message";                    
                    return message;
                }
                catch
                {
                    return message;
                }
            }
        }

    }
}