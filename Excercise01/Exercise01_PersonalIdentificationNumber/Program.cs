using System;

namespace Exercise01_PersonalIdentificationNumber
{
    class Program
    {
        static bool isValid(string personalIdentificationNumber)
        {
            if (personalIdentificationNumber.Length != 10) return false;

            ulong number = 0;
            try
            {
                number = UInt64.Parse(personalIdentificationNumber);
            } catch(FormatException)
            {
                Console.WriteLine("Unable to parse personalIdentificationNumber");
            }

            return number % 11 == 0;
        }

        static string sex(string personalIdentificationNumber)
        {
            return personalIdentificationNumber[2] == '5' || personalIdentificationNumber[2] == '6' ? "female" : "male";
        }
        static void Main(string[] args)
        {
            string personalIdentificationNumber = "1234567890";
            if(isValid(personalIdentificationNumber))
            {
                Console.WriteLine(sex(personalIdentificationNumber));
            } else
            {
                Console.WriteLine("Personal identification number is not valid");
            }
        }
    }
}
