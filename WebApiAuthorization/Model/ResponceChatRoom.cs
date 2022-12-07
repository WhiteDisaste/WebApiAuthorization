using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiAuthorization.Models;

namespace WebApiAuthorization.Model
{
    public partial class ResponceChatRoom
    {
        public ResponceChatRoom(Chatroom chatroom)
        {
            Id = chatroom.Id;
            Topic = chatroom.Topic;
            GetLastMessage = chatroom.LastMessage;
        }

        public int Id { get; set; }
        public string Topic { get; set; }
        public string GetLastMessage { get; set; }
    }
}