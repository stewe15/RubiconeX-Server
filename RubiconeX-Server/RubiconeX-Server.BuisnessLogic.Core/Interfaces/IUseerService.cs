using RubiconeX_Server.BuisnessLogic.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiconeX_Server.BuisnessLogic.Core.Interfaces
{
    public interface IUseerService
    {
        Task<UserInformationBlo> Auth(int phoneNumberPreFix, int phoneNumber, string password );
        Task<UserInformationBlo> Registration(int phoneNumberPreFix, int phoneNumber, string password);
        Task<UserInformationBlo> Get(int UserId);
        Task<UserInformationBlo> Update(int phoneNumberPreFix, int phoneNumber, string password, UserUpdateBlo userUpdateBlo);
        Task<bool> DoesExist(int phoneNumberPreFix, int phoneNumber);
        
    }
     
}
