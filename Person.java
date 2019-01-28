// Import utilities
import java.time.Year;
import java.util.Scanner;

class Person {

    // Define gender class
    public enum Sex {
        male, female
    }

    // Define basic variables' types
    private String name, last_name, season;
    private String age;
    private Sex sex;

    // Create a new scanner for this class
    private Scanner sc = new Scanner(System.in);

    // Encapsulation with methods for data management and refinement
    void setName() {
        name = sc.nextLine();
        while (!name.matches("^[a-zA-Z]+$")) {
            System.out.println("Please enter a valid first name:");
            name = sc.nextLine();
        }
    }

    String getName() {
        return name.substring(0, 1).toUpperCase() + name.substring(1).toLowerCase();
    }

    void setLastName() {
        last_name = sc.nextLine();
        while (!last_name.matches("^[a-zA-Z]+$")) {
            System.out.println("Please enter a valid last name:");
            last_name = sc.nextLine();
        }
    }

    private String getLastName() {
        return last_name.substring(0, 1).toUpperCase() + last_name.substring(1).toLowerCase();
    }

    void setAge() {
        age = sc.nextLine();
        while (!String.valueOf(age).matches("^[0-9]+$") || Integer.parseInt(age) < 1 || Integer.parseInt(age) > 150) {
            System.out.println("Please enter a valid integer:");
            age = sc.nextLine();
        }
    }

    int getAge() {
        return Integer.parseInt(age);
    }

    void setSex(Sex sex) {
        this.sex = sex;
    }

    private Sex getSex() {
        return sex;
    }

    void setSeason() {
        season = sc.nextLine();
        while (!(season.equalsIgnoreCase("spring") || season.equalsIgnoreCase("summer") || season.equalsIgnoreCase("autumn") || season.equalsIgnoreCase("winter"))) {
            System.out.println("Please enter only names of seasons:");
            season = sc.nextLine();
        }
    }

    private String getSeason() {
        return season;
    }

    // Defining a method to print cumulative data for the family
    String printData() {
        return getName() + " " + getLastName() + ", " + getAge() + " years old, " + getSex() + ".";
    }

    // 2050 birthday calculator (using java.time.Year util to avoid inserting current year manually)
    int printFutureAge() {
        int future_birthday;
        int current_year = Year.now().getValue();
        future_birthday = 2050 - (current_year - getAge());
        return future_birthday;
    }

    // Method to print family's preferences based on their favorite seasons
    String preference() {
        if (getSeason().equalsIgnoreCase("spring")) {
            return " likes flowers. Watch out for allergies!";
        } else if (getSeason().equalsIgnoreCase("summer")) {
            return " likes swimming, sun tanning, and Super Paradise!";
        } else if (getSeason().equalsIgnoreCase("autumn")) {
            return " likes rain. What a nostalgic personality...";
        } else if (getSeason().equalsIgnoreCase("winter")) {
            return " likes snow. Let's go snowboarding!";
        } else {
            return " - Sorry, I cannot work anymore. Please restart me.";
        }
    }
}