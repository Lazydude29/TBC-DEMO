using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserServices.Interfaces
{
    public interface IUserService
    {
        public Task<bool> TryRegisterAsync(string username, string password);
    }
}
