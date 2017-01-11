using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleApplication
{
    class Program
    {
       public static void Main(string[] args)
        {
            Country C1 = new Country() { Code = "AUS", Name = "Australia", Capital = "Canberra" };
            Country C2 = new Country() { Code = "IND", Name = "India", Capital = "New Delhi" };
            Country C3 = new Country() { Code = "USA", Name = "United States", Capital = "Washington D.C." };
            Country C4 = new Country() { Code = "GBR", Name = "United Kingdom", Capital = "London" };
            Country C5 = new Country() { Code = "CAN", Name = "Canada", Capital = "Ottawa" };

            Dictionary<string, Country> DictionaryList = new Dictionary<string, Country>();
            DictionaryList.Add(C1.Code, C1);
            DictionaryList.Add(C2.Code, C2);
            DictionaryList.Add(C3.Code, C3);
            DictionaryList.Add(C4.Code, C4);
            DictionaryList.Add(C5.Code, C5);

            //Here List is is the worth choice,,,,
            //Dictionary is the best choice.....
            //List<Country> CountryList = new List<Country>();
            //CountryList.Add(C1);
            //CountryList.Add(C2);
            //CountryList.Add(C3);
            //CountryList.Add(C4);
            //CountryList.Add(C5);


            string strUserChoice = string.Empty;
            do
            {
                Console.WriteLine("Please enter a country code.");
                string strCountryCode = Console.ReadLine().ToUpper();
                // Country result = CountryList.Find(country => country.Code == strCountryCode); //For List

                Country result = DictionaryList.ContainsKey(strCountryCode) ? DictionaryList[strCountryCode] :null ;
                if (result == null)
                {
                    Console.WriteLine("Country Code not valid.");
                }
                else
                {
                    Console.WriteLine("Country = {0}, Capital = {1}", result.Name, result.Capital);
                }
                do
                {
                    Console.WriteLine("Do you want to continue - YES or NO?");
                    strUserChoice = Console.ReadLine().ToUpper();
                }
                while (strUserChoice != "NO" && strUserChoice != "YES");
            }
            while (strUserChoice=="YES");
        }
    }

    public class Country
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Capital { get; set; }

    }
}
