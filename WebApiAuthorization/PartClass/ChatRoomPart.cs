using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;


namespace WebApiAuthorization.Models
{
    public partial class Chatroom
    {
        private AppDeminEntities db = new AppDeminEntities();
        public string GetLastMessage
        {
            get
            {
                string message = "No";
                try
                {
                    message = db.ChatMessage.LastOrDefault()?.TextMessage ?? "No message";                    
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