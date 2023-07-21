
using MotivationAPI.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotivationAPI.Core.Interfaces.Services
{
    public interface IMotivationalQuotesService
    {
        public MotivationalQuotesResponse GetMotivation();
    }
}
