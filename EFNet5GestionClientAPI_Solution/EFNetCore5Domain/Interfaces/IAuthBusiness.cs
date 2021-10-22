using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EFNetCore5Domain.Models;
using EFNetCore5Domain.Models.Requests.Auth;

namespace EFNetCore5Domain.Interfaces
{
    public interface IAuthBusiness
    {
        TokenModel ConnectUser(ConnectUserRequest request);
    }
}