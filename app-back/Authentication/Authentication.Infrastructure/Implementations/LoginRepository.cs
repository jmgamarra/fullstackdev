using Authentication.Core.DTOs;
using Authentication.Core.Entities;
using Authentication.Core.Interfaces;
using Authentication.Infrastructure.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Net;

namespace Authentication.Infrastructure.Implementations
{
    public class LoginRepository:ILoginRepository
    {
        private readonly DataContext _context;
        public LoginRepository(DataContext context)
        {
            this._context = context;
        }
        public  Response Check(UserDTO pUser)
        {
            try
            {
                var query = _context.JsonResponse.FromSqlRaw("exec usp_Validate_User {0},{1}", pUser.email, pUser.password).ToList();
                int isValid = query[0].DBResponse;
                if (isValid > 0)
                {
                    return new Response()
                    {
                        code = (int)HttpStatusCode.OK,
                        messsage = "Successful",
                        content = true

                    };
                }
                else {
                    return new Response()
                    {
                        code = (int)HttpStatusCode.OK,
                        messsage = "Successful",
                        content = false

                    };
                }
            }
            catch (Exception ex)
            {
                return new Response()
                {
                    code = (int)HttpStatusCode.BadRequest,
                    messsage = "Error" + ex.ToString(),
                    content = false

                };
            }
            
          
        }
    }
}
