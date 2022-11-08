using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiAuthorization.Models
{
    public partial class ChatMessage
    {
        private AppDeminEntities db = new AppDeminEntities();

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