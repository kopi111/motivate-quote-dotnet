using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotivationAPI.Core.DTOs
{
    
        public record MotivationalQuotesResponse(string Quote, string Owner)
        {
            public MotivationalQuotesResponse() : this(string.Empty, string.Empty) { }
        }
    
}
