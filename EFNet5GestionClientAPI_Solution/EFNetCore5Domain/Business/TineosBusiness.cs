using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EFNetCore5Domain.Interfaces;
using EFNetCore5Domain.Models;
using EFNetCore5Domain.Models.Requests;

namespace EFNetCore5Domain.Business
{
    public class TineosBusiness : ITineosBusiness
    {
        public ITineosManager _tineosManager;

        public TineosBusiness(ITineosManager tineosManager)
        {
            _tineosManager = tineosManager;
        }

        public TineosModel AddTineos(AddTineosRequest request)
        {
            var tineosToAdd = new TineosModel
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                JobFunction = request.JobFunction,
                Mail = request.Mail,
                StartDate = request.StartDate
            };
            return _tineosManager.AddTineos(tineosToAdd, request.Password);
        }

        public List<TineosModel> GetAllTineos()
        {
            return _tineosManager.GetAllTineos();
        }
    }
}