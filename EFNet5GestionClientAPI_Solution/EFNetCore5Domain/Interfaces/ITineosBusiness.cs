using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EFNetCore5Domain.Models;
using EFNetCore5Domain.Models.Requests;

namespace EFNetCore5Domain.Interfaces
{
    public interface ITineosBusiness
    {
        TineosModel AddTineos(AddTineosRequest request);

        List<TineosModel> GetAllTineos();
    }
}