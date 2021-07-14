using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace KanyeRest
{
	class Program
	{
		static void Main(string[] args)
		{
			for(int i= 0; i < 5; i++)
			{
				QuoteGenerator.RonQuote();
				QuoteGenerator.KanyeQuote();
			}


		}
	}
}
