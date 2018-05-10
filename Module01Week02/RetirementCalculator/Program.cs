using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetirementCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please provide your year of birth: ");
            int getYearOfBirth = int.Parse(Console.ReadLine());

            Console.Write("Please provide your month of birth: ");
            int getMonthOfBirth = int.Parse(Console.ReadLine());

            Console.Write("Please provide your day of birth: ");
            int getDayOfBirth = int.Parse(Console.ReadLine());

            DateTime birthDate = new DateTime(getYearOfBirth,getMonthOfBirth,getDayOfBirth);

            TimeSpan calculateAge = new TimeSpan();
            calculateAge = DateTime.Now - birthDate;
            int getNumberOfYears = new DateTime(calculateAge.Ticks).Year;

            Console.Write("Please provide your gender (F/M): ");
            string requestGender = Console.ReadLine();
            int? selectedGender;

            if (requestGender == "F")
            {
                providedGender suppliedGender = providedGender.Female;
                selectedGender = (int)suppliedGender;
            }
            else if(requestGender == "M")
            {
                providedGender suppliedGender = providedGender.Male;
                selectedGender = (int)suppliedGender;
            }
            else
            {
                selectedGender = null;
            }

            switch (selectedGender)
            {
                case 0:
                    Console.WriteLine($"You can retire at the age of 63. You have {63 - getNumberOfYears} years left until you can retire.");
                    break;
                case 1:
                    Console.WriteLine($"You can retire at the age of 65. You have {65 - getNumberOfYears} years left until you can retire.");
                    break;
                default:
                    Console.WriteLine($"You probably supplied an invalid gender. You supplied the value: \"{requestGender}\"");
                    break;
            }
            Console.ReadLine();

        }  
        
        public enum providedGender
        {
            Female,
            Male
        }
        
    }
}
