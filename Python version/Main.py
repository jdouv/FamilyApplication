from Person import Person
import re

# Print welcome message
print("\n*** Welcome! ***\nThis is the Family Application, the biggest family gossiper!\n" +
      "Give me details about your family and I'll do some tricks for you!\n\nLet\'s get started!\n\n")

# Define basic objects
father = Person()
mother = Person()
son = Person()
daughter = Person()


def set_name(name):
    while not re.search("^[a-zA-Z]+$", name):
        name = input("Please enter a valid first name: ")
    return name


def set_last_name(last_name):
    while not re.search("^[a-zA-Z]+$", last_name):
        last_name = input("Please enter a valid first name: ")
    return last_name


def set_age(age):
    while not age.isdigit():
        age = input("Please enter a valid integer: ")
    return age


def set_season(season):
    while not (season.lower() == "spring" or season.lower() == "summer" or season.lower() == "autumn"
               or season.lower() == "winter"):
        season = input("Please enter only names of seasons: ")
    return season


# Input users' data starting from father
father.name = set_name(input("Now, give me the father's first name: "))
father.last_name = set_last_name(input("Good. Now tell me his last name: "))
father.age = set_age(input("Excellent! How old is he? "))
print("Awesome! Till now, we have to deal with a man - don't panic, I'm smart; I know how to distinguish males from"
      " females!")
father.sex = Person.Sex.MALE
father.season = set_season(input("Finally, tell me something more personal: Which is his favorite season, spring,"
                                 " summer, autumn or winter? "))

# Mother
mother.name = set_name(input("\nNow let's move on to mama. What's her first name? "))
mother.last_name = set_last_name(input("What a wonderful name! And her last name? "))
mother.age = set_age(input("And how old is she? "))
print("Good. A woman in the deal.")
mother.sex = Person.Sex.FEMALE
mother.season = set_season(input("To build up her profile I want to know her favorite season, as you previously did"
                                 " with dad: "))

# Son
son.name = set_name(input("\nGreat! Enough with parents; let's move on with their children.\nWhat's their son's first "
                          "name? "))
son.last_name = set_last_name(input("And his last name (maybe the same as his father's)? "))
son.age = set_age(input("Brilliant! How old is he? "))
print("Wow, a boy ready for action!")
son.sex = Person.Sex.MALE
son.season = set_season(input("Like before, tell me his favorite season: "))

# Daughter
daughter.name = set_name(input("\nNow let's go to the last but not least, the daughter! What's her first name? "))
daughter.last_name = set_last_name(input("Her last name (I'm sure it's the same as her brother's, but you never "
                                         "know)? "))
daughter.age = set_age(input("Her age? "))
print("A beautiful girl.")
daughter.sex = Person.Sex.FEMALE
daughter.season = set_season(input("To conclude, tell me her favorite season, like before: "))

# Print family's data based on age (2 groups comparison: father-mother and son-daughter since children will never be
# older than their parents)

print("\nOK, here's what we have until now:\nA four-membered family with the following information sorted by their ages"
      " in descending order:\n")
if father.age > mother.age or father.age == mother.age:
    father.print_data()
    mother.print_data()
elif mother.age > father.age:
    mother.print_data()
    father.print_data()
else:
    print("Oops! Something happened and I cannot show you the parents' information")

if son.age > daughter.age or son.age == daughter.age:
    son.print_data()
    daughter.print_data()
elif daughter.age > son.age:
    daughter.print_data()
    son.print_data()
else:
    print("Oops! Something happened and I cannot show you the children\'s information.\n")

# Print 2050 age predictions
print("Well, let's do the psychics and predict how old the family will be in 2050!\n" +
      father.name.title() + " will be " + father.print_future_age() + " years old, " +
      mother.name.title() + " will be " + mother.print_future_age() + ", " +
      son.name.title() + " " + son.print_future_age() + ", and " +
      daughter.name.title() + " will be " + daughter.print_future_age() + " years old.\n")

# Print family's preferences
print("Now I'll show you what each one of them prefers according to his/her season preference:\n")
father.preference()
mother.preference()
son.preference()
daughter.preference()

# Print closing message
print("That's all for now! If you like me, subscribe to koutsobolio.com!\n*********************************************"
      "********************\n")
