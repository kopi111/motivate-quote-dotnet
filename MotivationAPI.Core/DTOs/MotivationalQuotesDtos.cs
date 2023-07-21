using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotivationAPI.ApplicationService.DTOs
{
    public record MotivationalQuotesDtos
    {
        public record MotivationalQuotes(string Motivationquote, string person)
        {
            public MotivationalQuotes() : this (string.Empty, string.Empty) { }
        }


    }
}
