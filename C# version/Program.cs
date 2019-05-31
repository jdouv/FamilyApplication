using System;

namespace FamilyApplication
{
    internal static class Program
    {
        private static void Main()
        {
        // Print welcome message
        Console.WriteLine("\n*** Welcome! ***\nThis is the Family Application, the biggest family gossiper!\n" +
                "Give me details about your family and I'll do some tricks for you!\n\nLet\'s get started!\n\n");

        // Define basic objects
        var father = new Person();
        var mother = new Person();
        var son = new Person();
        var daughter = new Person();

        // Input users' data starting from father
        Console.WriteLine("Now, give me the father's first name:");
        father.SetName();
        Console.WriteLine("Good. Now tell me his last name:");
        father.SetLastName();
        Console.WriteLine("Excellent! How old is he?");
        father.SetAge();
        Console.WriteLine("Awesome! Till now, we have to deal with a man - don't panic, I'm smart; I know how to distinguish males from females!");
        father.SetSex(Person.Sex.Male);
        Console.WriteLine("Finally, tell me something more personal: Which is his favorite season, spring, summer, autumn or winter?");
        father.SetSeason();

        // Mother
        Console.WriteLine("\nNow let's move on to mama. What's her first name?");
        mother.SetName();
        Console.WriteLine("What a wonderful name! And her last name?");
        mother.SetLastName();
        Console.WriteLine("And how old is she?");
        mother.SetAge();
        Console.WriteLine("Good. A woman in the deal.");
        mother.SetSex(Person.Sex.Female);
        Console.WriteLine("To build up her profile I want to know her favorite season, as you previously did with dad:");
        mother.SetSeason();

        // Son
        Console.WriteLine("\nGreat! Enough with parents; let's move on with their children.\nWhat's their son's first name?");
        son.SetName();
        Console.WriteLine("And his last name (maybe the same as his father's)?");
        son.SetLastName();
        Console.WriteLine("Brilliant! How old is he?");
        son.SetAge();
        Console.WriteLine("Wow, a boy ready for action!");
        son.SetSex(Person.Sex.Male);
        Console.WriteLine("Like before, tell me his favorite season:");
        son.SetSeason();

        // Daughter
        Console.WriteLine("\nNow let's go to the last but not least, the daughter! What's her first name?");
        daughter.SetName();
        Console.WriteLine("Her last name (I'm sure it's the same as her brother's, but you never know)?");
        daughter.SetLastName();
        Console.WriteLine("Her age?");
        daughter.SetAge();
        Console.WriteLine("A beautiful girl.");
        daughter.SetSex(Person.Sex.Female);
        Console.WriteLine("To conclude, tell me her favorite season, like before:");
        daughter.SetSeason();

        // Print family's data based on age (2 groups comparison:father-mother and son-daughter since children will never be older than their parents)
        Console.WriteLine("\nOK, here's what we have until now:\nA four-membered family with the following information sorted by their ages in descending order:\n");
        if (father.GetAge() > mother.GetAge() || father.GetAge() == mother.GetAge())
        {
            Console.WriteLine(father.PrintData());
            Console.WriteLine(mother.PrintData());
        } else if (mother.GetAge() > father.GetAge())
        {
            Console.WriteLine(mother.PrintData());
            Console.WriteLine(father.PrintData());
        } else {
            Console.WriteLine("Oops! Something happened and I cannot show you the parents' information");
        }
        if (son.GetAge() > daughter.GetAge() || son.GetAge() == daughter.GetAge())
        {
            Console.WriteLine(son.PrintData());
            Console.WriteLine(daughter.PrintData() + "\n");
        } else if (daughter.GetAge() > son.GetAge())
        {
            Console.WriteLine(daughter.PrintData());
            Console.WriteLine(son.PrintData() + "\n");
        } else {
            Console.WriteLine("Oops! Something happened and I cannot show you the children\'s information.\n");
        }

        // Print 2050 age predictions
        Console.WriteLine("Well, let's do the psychics and predict how old the family will be in 2050!\n" +
                father.GetName() + " will be " + father.PrintFutureAge() + " years old, " +
                mother.GetName() + " will be " + mother.PrintFutureAge() + ", " +
                son.GetName()+ " " + son.PrintFutureAge() + ", and " +
                daughter.GetName() + " will be " + daughter.PrintFutureAge() + " years old.\n");

        // Print family's preferences
        Console.WriteLine("Now I'll show you what each one of them prefers according to his/her season preference:\n" +
                father.GetName() + father.Preference() + "\n" +
                mother.GetName() + mother.Preference() + "\n" +
                son.GetName() + son.Preference() + "\n" +
                daughter.GetName() + daughter.Preference() + "\n");

        // Print closing message
        Console.Write("That's all for now! If you like me, subscribe to koutsobolio.com!\n*****************************************************************\n");
        }
    }
}
