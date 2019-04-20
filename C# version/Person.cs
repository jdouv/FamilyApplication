using System;
using System.Linq;

namespace FamilyApplication
{
    public class Person
    {
        // Define gender class
        public enum Sex {
            Male, Female
        }
        
        // Define basic variables' types
        private string _name, _lastName, _age, _season;
        private Sex _sex;
        
        // Encapsulation with methods for data management and refinement
        internal void SetName()
        {
            _name = Console.ReadLine();
            while (_name != null && !_name.All(char.IsLetter))
            {
                Console.WriteLine("Please enter a valid first name:");
                _name = Console.ReadLine();
            }
        }
        
        internal string GetName()
        {
            return _name.Substring(0, 1).ToUpper() + _name.Substring(1).ToLower();
        }
        
        internal void SetLastName()
        {
            _lastName = Console.ReadLine();
            while (_lastName != null && !_lastName.All(char.IsLetter))
            {
                Console.WriteLine("Please enter a valid last name:");
                _lastName = Console.ReadLine();
            }
        }

        private string GetLastName()
        {
            return _lastName.Substring(0, 1).ToUpper() + _lastName.Substring(1).ToLower();
        }

        internal void SetAge()
        {
            _age = Console.ReadLine();
            while (_age != null && (!_age.All(char.IsNumber) || Convert.ToInt32(_age) < 1 || Convert.ToInt32(_age) > 150))
            {
                Console.WriteLine("Please enter a valid integer:");
                _age = Console.ReadLine();
            }
        }
        
        internal int GetAge()
        {
            return Convert.ToInt32(_age);
        }

        internal void SetSex(Sex sex)
        {
            _sex = sex;
        }

        private Sex GetSex()
        {
            return _sex;
        }
        
        internal void SetSeason()
        {
            _season = Console.ReadLine();
            while (_season != null && !(_season.Equals("spring", StringComparison.OrdinalIgnoreCase) ||
                                        _season.Equals("summer", StringComparison.OrdinalIgnoreCase) ||
                                        _season.Equals("autumn", StringComparison.OrdinalIgnoreCase) ||
                                        _season.Equals("winter", StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine("Please enter only names of seasons:");
                _season = Console.ReadLine();
            }
        }

        private string GetSeason()
        {
            return _season;
        }

        // Defining a method to print cumulative data for the family
        internal string PrintData()
        {
            return GetName() + " " + GetLastName() + ", " + GetAge() + " years old, "
                   + GetSex().ToString().Substring(0, 1).ToLower()
                   + GetSex().ToString().Substring(1).ToLower() + ".";
        }
        
        // 2050 birthday calculator (using DateTime.Today.Year util to avoid inserting current year manually)
        internal int PrintFutureAge()
        {
            var currentYear = DateTime.Today.Year;
            var futureBirthday = 2050 - (currentYear - GetAge());
            return futureBirthday;
        }

        // Method to print family's preferences based on their favorite seasons
        internal string Preference()
        {
            if (GetSeason().Equals("spring", StringComparison.OrdinalIgnoreCase))
            {
                return " likes flowers. Watch out for allergies!";
            }
            if (GetSeason().Equals("summer", StringComparison.OrdinalIgnoreCase))
            {
                return " likes swimming, sun tanning, and Super Paradise!";
            }
            if (GetSeason().Equals("autumn", StringComparison.OrdinalIgnoreCase))
            {
                return " likes rain. What a nostalgic personality...";
            }
            if (GetSeason().Equals("winter", StringComparison.OrdinalIgnoreCase))
            {
                return " likes snow. Let's go snowboarding!";
            }
            {
                return " - Sorry, I cannot work anymore. Please restart me.";
            }
        }
    }
}