using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Services
{
    public class NewApiServices
    {
        public string RPSRandom()
        {
            Random cpuChoice = new Random();

            string[] playerOption = ["rock", "paper", "scissors"];

            return playerOption[cpuChoice.Next(0,5)];
        }
    }
}