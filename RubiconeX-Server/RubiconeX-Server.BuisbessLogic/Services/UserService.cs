using RubiconeX_Server.BuisnessLogic.Core.Interfaces;
using RubiconeX_Server.BuisnessLogic.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiconeX_Server.BuisbessLogic.Services
{
    public class UserService : IUseerService
    {
        public Task<UserInformationBlo> Auth(int phoneNumberPreFix, int phoneNumber, string password)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DoesExist(int phoneNumberPreFix, int phoneNumber)
        {
            throw new NotImplementedException();
        }

        public Task<UserInformationBlo> Get(int UserId)
        {
            throw new NotImplementedException();
        }

        public Task<UserInformationBlo> Registration(int phoneNumberPreFix, int phoneNumber, string password)
        {
            throw new NotImplementedException();
        }

        public Task<UserInformationBlo> Update(int phoneNumberPreFix, int phoneNumber, string password, UserUpdateBlo userUpdateBlo)
        {
            throw new NotImplementedException();
        }
    }
}
