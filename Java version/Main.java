public class Main {

    public static void main(String[] args) {

        // Print welcome message
        System.out.println("\n*** Welcome! ***\nThis is the Family Application, the biggest family gossiper!\n" +
                "Give me details about your family and I'll do some tricks for you!\n\nLet\'s get started!\n\n");

        // Define basic objects
        Person father = new Person();
        Person mother = new Person();
        Person son = new Person();
        Person daughter = new Person();

        // Input user's data starting from father
        System.out.println("Now, give me the father's first name:");
        father.setName();
        System.out.println("Good. Now tell me his last name:");
        father.setLastName();
        System.out.println("Excellent! How old is he?");
        father.setAge();
        System.out.println("Awesome! Till now, we have to deal with a man - don't panic, I'm smart; I know how to distinguish males from females!");
        father.setSex(Person.Sex.male);
        System.out.println("Finally, tell me something more personal: Which is his favorite season, spring, summer, autumn or winter?");
        father.setSeason();

        // Mother
        System.out.println("\nNow let's move on to mama. What's her first name?");
        mother.setName();
        System.out.println("What a wonderful name! And her last name?");
        mother.setLastName();
        System.out.println("And how old is she?");
        mother.setAge();
        System.out.println("Good. A woman in the deal.");
        mother.setSex(Person.Sex.female);
        System.out.println("To build up her profile I want to know her favorite season, as you previously did with dad:");
        mother.setSeason();

        // Son
        System.out.println("\nGreat! Enough with parents; let's move on with their children.\nWhat's their son's first name?");
        son.setName();
        System.out.println("And his last name (maybe the same as his father's)?");
        son.setLastName();
        System.out.println("Brilliant! How old is he?");
        son.setAge();
        System.out.println("Wow, a boy ready for action!");
        son.setSex(Person.Sex.male);
        System.out.println("Like before, tell me his favorite season:");
        son.setSeason();

        // Daughter
        System.out.println("\nNow let's go to the last but not least, the daughter! What's her first name?");
        daughter.setName();
        System.out.println("Her last name (I'm sure it's the same as her brother's, but you never know)?");
        daughter.setLastName();
        System.out.println("Her age?");
        daughter.setAge();
        System.out.println("A beautiful girl.");
        daughter.setSex(Person.Sex.female);
        System.out.println("To conclude, tell me her favorite season, like before:");
        daughter.setSeason();

        // Print family's data based on age (2 groups comparison:father-mother and son-daughter since children will never be older than their parents)
        System.out.println("\nOK, here's what we have until now:\nA four-membered family with the following information sorted by their ages in descending order:\n");
        if (father.getAge() > mother.getAge() || father.getAge() == mother.getAge()) {
            System.out.println(father.printData());
            System.out.println(mother.printData());
        } else if (mother.getAge() > father.getAge()) {
            System.out.println(mother.printData());
            System.out.println(father.printData());
        } else {
            System.out.println("Oops! Something happened and I cannot show you the parents' information");
        }
        if (son.getAge() > daughter.getAge() || son.getAge() == daughter.getAge()) {
            System.out.println(son.printData());
            System.out.println(daughter.printData() + "\n");
        } else if (daughter.getAge() > son.getAge()) {
            System.out.println(daughter.printData());
            System.out.println(son.printData() + "\n");
        } else {
            System.out.println("Oops! Something happened and I cannot show you the children\'s information.\n");
        }

        // Print 2050 age predictions
        System.out.println("Well, let's do the psychics and predict how old the family will be in 2050!\n" +
                father.getName() + " will be " + father.printFutureAge() + " years old, " +
                mother.getName() + " will be " + mother.printFutureAge() + ", " +
                son.getName()+ " " + son.printFutureAge() + ", and " +
                daughter.getName() + " will be " + daughter.printFutureAge() + " years old.\n");

        // Print family's preferences
        System.out.println("Now I'll show you what each one of them prefers according to his/her season preference:\n" +
                father.getName() + father.preference() + "\n" +
                mother.getName() + mother.preference() + "\n" +
                son.getName() + son.preference() + "\n" +
                daughter.getName() + daughter.preference() + "\n");

        // Print closing message
        System.out.print("That's all for now! If you like me, subscribe to koutsobolio.com!\n*****************************************************************\n");
    }
}
