# Import utilities
import datetime
from enum import Enum


class Person:
    # Define gender enum
    class Sex(Enum):
        MALE = 1
        FEMALE = 2

    # Defining a method to print cumulative data for the family
    def print_data(self):
        print(self.name.title() + " " + self.last_name.title() + ", " + self.age + " years old, "
              + str(self.sex.name).lower() + ".")

    # 2050 birthday calculator (by importing datetime to avoid inserting current year manually)
    def print_future_age(self):
        current_year = int(datetime.datetime.now().year)
        future_birthday = 2050 - (current_year - int(self.age))
        return str(future_birthday)

    # Method to print family's preferences based on their favorite seasons
    def preference(self):
        if self.season.lower() == "spring":
            print(self.name.title() + " likes flowers. Watch out for allergies!")
        elif self.season.lower() == "summer":
            print(self.name.title() + " likes swimming, sun tanning, and Super Paradise!")
        elif self.season.lower() == "autumn":
            print(self.name.title() + " likes rain. What a nostalgic personality...")
        elif self.season.lower() == "winter":
            print(self.name.title() + " likes snow. Let's go snowboarding!")
        else:
            print(" - Sorry, I cannot work anymore. Please restart me.")
