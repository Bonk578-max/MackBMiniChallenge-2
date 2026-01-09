using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MackBMiniChallenge_2.Services
{
    public class TwoInputQuestionsServices
    {
        public string ReturnResponse(string name, string time)
        {
            return $"This, is your name: {name} and you decided to wake up at {time}. Howdy!";
        }
    }
}