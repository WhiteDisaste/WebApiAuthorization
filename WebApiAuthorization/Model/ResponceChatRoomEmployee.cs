using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiAuthorization.Models;

namespace WebApiAuthorization.Model
{
    public class ResponceChatRoomEmployee
    {

        public ResponceChatRoomEmployee(ChatroomEmployee roomEmployee)
        {
            Id = roomEmployee.Id;
            IdChatroom = roomEmployee.IdChatroom;
            IdUser = roomEmployee.IdUser;
        }


        public int Id { get; set; }
        public int? IdChatroom { get; set; }
        public int? IdUser { get; set; }
    }
}