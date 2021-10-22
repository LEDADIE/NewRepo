using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFNet5GestionClientAPI.Domain
{
    public class AutResult
    {
        public List<string> Errors { get; set; }
        public bool Result { get; set; }
        public string Token { get; set; }
    }
}