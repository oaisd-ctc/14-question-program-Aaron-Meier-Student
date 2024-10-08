using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("What is your Full Name?"); 
        string fullName = Console.ReadLine();
        Console.WriteLine("What is your Age?"); 
        string age = Console.ReadLine();
        Console.WriteLine("What is your Eye Color?"); 
        string eyeColor = Console.ReadLine();
        Console.WriteLine("What is your Hair Color?"); 
        string hairColor = Console.ReadLine();
        Console.WriteLine("What is your Shoe Size?"); 
        string shoeSize = Console.ReadLine();
        Console.WriteLine("What is your Favorite Color?"); 
        string favoriteColor = Console.ReadLine();
        Console.WriteLine("What is your Favorite TV Show or Movie?"); 
        string favoriteShowOrMovie = Console.ReadLine();
        Console.WriteLine("What is your Favorite Teacher?"); 
        string favoriteTeacher = Console.ReadLine();
        Console.WriteLine("What is your Favorite Class?"); 
        string favoriteClass = Console.ReadLine();
        Console.WriteLine("What is your Favorite Holiday?"); 
        string favoriteHoliday = Console.ReadLine();
        Console.WriteLine("What is your Favorite Season?"); 
        string favoriteSeason = Console.ReadLine();
        Console.WriteLine("What is your Dream Job?"); 
        string dreamJob = Console.ReadLine();
        Console.WriteLine("How many siblings do you have?"); 
        string siblings = Console.ReadLine();
        int ageIn5Years = int.Parse(age)+5;
        
        Console.WriteLine($"My friend's anme is {fullName}. {fullName} is {age} years old. {fullName}'s eye color is {eyeColor}. {fullName}'s hair color is {hairColor}. {fullName}'s shoe size is {shoeSize}. {fullName}'s favorite color is {favoriteColor}. {fullName}'s favorite TV show or movie is {favoriteShowOrMovie}. {fullName}'s favorite teacher is {favoriteTeacher}. {fullName}'s favorite class is {favoriteClass}. {fullName}'s favorite holiday is {favoriteHoliday}. {fullName}'s dream job is {dreamJob}. {fullName} will be {ageIn5Years} in 5 years. . {fullName} has {siblings} siblings.");
    }
}
