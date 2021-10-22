using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EFNetCore5Domain.Models;

namespace EFNetCore5Domain.Interfaces
{
    public interface ITineosManager
    {
        TineosModel AddTineos(TineosModel request, string clearPassword);

        TineosModel AuthenticateTineos(string mail, string password);

        List<TineosModel> GetAllTineos();
    }
}