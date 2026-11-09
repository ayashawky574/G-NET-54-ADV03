using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Globalization;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1: Student Grade Manager
            //Create a Collection with these grades: 85, 92, 78, 95, 88, 70, 100, 65
            //List<int> gradeList = [85, 92, 78, 95, 88, 70, 100, 65];

            //Print the collection, Count, first and last grade
            //Console.WriteLine(gradeList.Count);
            //Console.WriteLine(gradeList[0]);
            //Console.WriteLine(gradeList[^1]);

            //Sort the grades ascending, then print
            //gradeList.Sort();
            //foreach(var item in gradeList)
            //{
            //    Console.WriteLine(item);
            //}

            //Get the first grade above 90
            //int first = gradeList.First(n => n > 90);
            //Console.WriteLine(first);

            //Get all grades below 75(failing grades)
            //List<int> failingGrade =gradeList.FindAll(n => n<75);
            //foreach (var item in failingGrade)
            //{
            //    Console.WriteLine(item);
            //}

            //Remove all failing grades(below 75)
            //gradeList.RemoveAll(n => n<75);

            //Check if any grade equals 100
            //bool isExist = gradeList.Any(n => n == 100);
            //Console.WriteLine(isExist);

            //Create a List<string> where each grade becomes "Grade: X"
            //List<string> grades = [];
            //foreach (var item in gradeList)
            //{
            //    grades.Add($"Grade : {item}");

            //}
            //foreach (var item in grades)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Exercise 2: Leaderboard

            //Add: 500 = "Ahmed", 200 = "Sara", 800 = "Ali", 350 = "Mona"
            // SortedList<int, string> leaderBoard = new()
            // {
            //     [500] = "Ahmed",
            //     [200] = "Sara",
            //     [800] = "Ali",
            //     [350] = "Mona"
            // };
            // //   -------------- OR-------------

            // //Print all entries(they should be sorted by score automatically)
            // foreach (var item in leaderBoard) 
            // {
            //     Console.WriteLine(item);
            // }

            // //Access the first key and first value
            //int firstKey = leaderBoard.First().Key;
            // int lastKey = leaderBoard.Last().Key;
            // Console.WriteLine(firstKey);
            // Console.WriteLine(lastKey);

            // //Check if score 500 exists

            // bool hasKey=  leaderBoard.ContainsKey(500);
            // Console.WriteLine(hasKey);

            // //Safely get the player with score 999
            // bool playerWith900 = leaderBoard.TryGetValue(500, out string player);
            // if (playerWith900)
            // {
            //     Console.WriteLine("player founded");
            // }
            // else
            // {
            //     Console.WriteLine("player not found");
            // }

            // //Remove the player with score 200 and print the updated list
            // leaderBoard.Remove(200);
            // Console.WriteLine("updated leader board :");
            // foreach(var item in leaderBoard)
            // {
            //     Console.WriteLine($"[{item.Key}]={item.Value}");
            // }
            #endregion

            #region Exercise 3: Phone Book
            //Create a Collection with 4 contacts(name → phone number)
            //Dictionary<string, int> phoneBook = new(4)
            //{
            //    ["aya" ]= 1234,
            //    ["amera"] = 456,
            //    ["omar"] = 6789
            //};


            ////Add a new contact using [] syntax (add or update)
            //phoneBook["mohamed"] = 987;

            ////Try adding a duplicate using .Add() — catch the exception and print the error
            //try
            //{
            //    phoneBook.Add("aya", 1234);
            //}
            //catch 
            //{
            //    Console.WriteLine("this phone number is already exist");
            //}

            ////Try adding a duplicate using .TryAdd() — print whether it succeeded
            //if(phoneBook.TryAdd("aya", 1234))
            //{
            //    Console.WriteLine("succeeded");
            //}

            ////Search for a contact that doesn’t exist
            //bool isExist = phoneBook.ContainsKey("ppp");

            //Console.WriteLine($"Exist : {isExist}");
            ////Get a contact with a fallback of "Not Found"
            //int value01 = phoneBook.GetValueOrDefault("ppppp", 0);
            //if (value01!= 0)
            //{
            //    Console.WriteLine("Not found");
            //}

            ////Print all Keys on one line, then all Values on another line
            //foreach (var key in phoneBook.Keys)
            //{
            //    Console.Write(key+" ");

            //}
            //Console.WriteLine();
            //foreach (var vlaue in phoneBook.Values)
            //{
            //    Console.Write(vlaue+" ");
            //}
            #endregion
        }
    }
}
