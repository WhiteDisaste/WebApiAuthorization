using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiAuthorization.Models;

namespace WebApiAuthorization.Model
{
    public partial class ResponceChatMessage
    {
        public ResponceChatMessage(ChatMessage chatMessage)
        {
            Id = chatMessage.Id;
            IdUser = (int)chatMessage.IdUser;
            IdChatRoom = (int)chatMessage.IdChatRoom;
            TextMessage = chatMessage.TextMessage;
            DateTime = (DateTime)chatMessage.DateTime;
            TakeMessage = chatMessage.TakeMessage;
        }
        public int Id { get; set; }
        public int IdUser { get; set; } //может быть NULL
        public int IdChatRoom { get; set; } //может быть NULL
        public string TextMessage { get; set; }
        public DateTime DateTime { get; set; } //может быть NULL

        public string TakeMessage { get; set; }
    }
}