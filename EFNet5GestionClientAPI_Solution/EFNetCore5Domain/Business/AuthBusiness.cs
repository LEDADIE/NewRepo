using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EFNetCore5Domain.Interfaces;
using EFNetCore5Domain.Models;
using EFNetCore5Domain.Models.Config;
using EFNetCore5Domain.Models.Requests.Auth;
using EFNetCore5Domain.Tools;

using Microsoft.Extensions.Options;

namespace EFNetCore5Domain.Business
{
    public class AuthBusiness : IAuthBusiness
    {
        public ITineosManager _tineosManager;
        private readonly IOptions<JwtSettings> _jwtSettings;

        public AuthBusiness(ITineosManager tineosManager, IOptions<JwtSettings> jwtSettings)
        {
            _tineosManager = tineosManager;
            _jwtSettings = jwtSettings;
        }

        public TokenModel ConnectUser(ConnectUserRequest request)
        {
            TokenModel result = null;
            var existingTineos = _tineosManager.AuthenticateTineos(request.Mail, request.Password);
            if (existingTineos != null)
            {
                result = new TokenModel
                {
                    Mail = existingTineos.Mail,
                    Token = TokenTool.GenerateJwt(existingTineos, _jwtSettings.Value)
                };
            }

            return result;
        }
    }
}