using MotivationAPI.Core.DTOs;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotivationAPI.Core.Interfaces.Repositories
{
    public interface IMotivationalRepository
    {
        public MotivationalQuotesResponse GetMotivation();
    }
}
