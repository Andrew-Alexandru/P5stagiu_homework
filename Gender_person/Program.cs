using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gender_person
{
    class Program
    {
        enum Gender { Female, Male, M, F};
        static void Main(string[] args)
        {
            int year, month, day;
            string gender;
            Console.Write("Give me the year: \n");
            year = int.Parse(Console.ReadLine());
            Console.Write("Give me the month:\n");
            month = int.Parse(Console.ReadLine());
            Console.Write("Give me the day:\n");
            day = int.Parse(Console.ReadLine());
            Console.Write("Give me the gender:\n");
            gender = Console.ReadLine();
            DateTime thisDate1 = new DateTime(year, month, day);
            Console.WriteLine("My birthday is on date: " + thisDate1.ToString("MMMM dd, yyyy") + ".");
            int age = 0;
            age = DateTime.Now.Year - year;
            Console.WriteLine("The age of the person is: {0}", age);
            if(gender.Equals(Gender.Female.ToString())|| gender.Equals(Gender.F.ToString()))
            {
                Console.WriteLine("You choose the gender:{0}", gender);
            }
            if (gender.Equals(Gender.Male.ToString()) || gender.Equals(Gender.M.ToString()))
            {
                Console.WriteLine("You choose the gender:{0}", gender);
            }
            if( age == 63 && (gender.Equals(Gender.Female.ToString()) || gender.Equals(Gender.F.ToString())))
            {
                Console.WriteLine("She is retired");
            }
            if (age == 65 && (gender.Equals(Gender.Male.ToString()) || gender.Equals(Gender.M.ToString())))
            {
                Console.WriteLine("He is retired");
            }
            else
            {
                if(age < 65 && age < 63)
                {
                    Console.WriteLine("He/She will retire in about :{0} years ", 65 - age);
                }
            }
            Console.ReadKey();
        }
    }
}
