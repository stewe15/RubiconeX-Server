using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiconeX_Server.BuisnessLogic.Core.Models
{
    public class UserUpdateBlo
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronumic { get; set; }
        public string AvatarUrl { get; set; }
        public string Introdution { get; set; }
    }
}
