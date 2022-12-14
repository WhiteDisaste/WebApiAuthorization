using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiAuthorization.Controllers;

namespace WebApiAuthorization.Models
{
    public partial class ChatMessage
    {
        private user18Entities db = new user18Entities();
        private ChatMessagesController.DataMessage message;

        public ChatMessage(ChatMessagesController.DataMessage message)
        {
            this.message = message;
        }

        public string TakeMessage
        {
            get
            {
                var emp = db.User.Where(i => i.Id == IdUser).FirstOrDefault();
                string mesage = $"[{DateTime?.Hour}:{DateTime?.Minute}] {emp.Name} : {TextMessage}";
                return mesage;
            }
        }
    }
}