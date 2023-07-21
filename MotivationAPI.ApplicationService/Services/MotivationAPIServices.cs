
using MotivationAPI.Core.DTOs;
using MotivationAPI.Core.Interfaces.Repositories;
using MotivationAPI.Core.Interfaces.Services;
using MotivationAPI.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotivationAPI.ApplicationService.Services
{
    public class MotivationAPIServices : IMotivationalQuotesService
    {

        private readonly IMotivationalRepository _motivationalRepository;

        public MotivationAPIServices(IMotivationalRepository motivationalRepository)
        {
            _motivationalRepository = motivationalRepository;
        }



        public MotivationalQuotesResponse GetMotivation()
        {
            var response = _motivationalRepository.GetMotivation();
            return response;
        }
    }
}
