using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyCDLibrary.Services;

namespace MyCDLibrary
{
    public class Quoter : IQuoter
    {
        public IEnumerable<string> _quotes;

        public Quoter()
        {
            _quotes = new List<string>
            {
                "We need more cowbell",
                "When I was three, maybe four, she left us at the video store",
                "Run To The Hills",
                "I kissed her goodbye, said all beauty must die"
            };
        }

        public string GetQuoteOfTheDay()
        {
            var random = new Random();
            var randomNumber = random.Next(0, _quotes.Count());
            return _quotes.ElementAt(randomNumber);
        }
    }
}
