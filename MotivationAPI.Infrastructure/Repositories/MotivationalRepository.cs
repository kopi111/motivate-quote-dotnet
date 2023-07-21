
using MotivationAPI.Core.DTOs;
using MotivationAPI.Core.Interfaces.Repositories;
using static MotivationAPI.ApplicationService.DTOs.MotivationalQuotesDtos;

namespace MotivationAPI.Infrastructure
{
    public class MotivationalRepository : IMotivationalRepository
    {

       
        public MotivationalQuotesResponse GetMotivation()
        {
           
            List<MotivationalQuotesResponse> quotes = LoadQuotesFromFile("quotes.txt");

            if (quotes.Count == 0)
            {
                
            }

            // Generate a random number within the range of the quotes list
            Random random = new Random();
            int randomIndex = random.Next(0, quotes.Count);

            MotivationalQuotesResponse randomQuote = quotes[randomIndex];

            return randomQuote;
        }

    

        static List<MotivationalQuotesResponse> LoadQuotesFromFile(string filePath)
        {
            List<MotivationalQuotesResponse> quotes = new List<MotivationalQuotesResponse>();
            filePath = "C:\\Users\\dwayn\\Desktop\\JMMB-pushNotificationAPI\\MotivationAPI.ApplicationService\\MotivationAPI.Infrastructure\\files\\quotes.txt";
            try
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    if (line.Trim().Length > 0)
                    {
                        int quoteStartIndex = line.IndexOf('"');
                        int quoteEndIndex = line.LastIndexOf('"');

                        if (quoteStartIndex != -1 && quoteEndIndex != -1)
                        {
                            string quote = line.Substring(quoteStartIndex + 1, quoteEndIndex - quoteStartIndex - 1).Trim();
                            string owner = line.Substring(quoteEndIndex + 1).Trim('-').Trim();

                            quotes.Add(new MotivationalQuotesResponse { Quote = quote, Owner = owner });
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found: " + filePath);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occurred while loading quotes: " + e.Message);
            }

            return quotes;
        }
    }
}
