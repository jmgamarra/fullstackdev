using Authentication.Core.DTOs;
using Authentication.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Authentication.Core.Interfaces
{
    public interface ILoginRepository
    {
        public Response Check(UserDTO pUser);
    }
}
