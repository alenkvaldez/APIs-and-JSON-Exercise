﻿using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 5; i++)
            {
                QuoteGenerator.KanyeQuote();

                QuoteGenerator.RonQuote();
            }

        }
    }
}
