using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    public class Student
    {
        public int ID;
        public string Name;
        public String HomeTown;
        public string Food;
        public Student(int id, string name, string town, string food)
        {
            this.ID = id;
            this.Name = name;
            this.HomeTown = town;
            this.Food = food;
        }

    }

    class Program
    {
        static List<Student> students = new List<Student>();

        static void Main(string[] args)
        {
            bool continue_student = true, continue_details = true;
            int id;
            string hometown, food;
            fillStudent();
            showStudents();
            Console.WriteLine();
            Console.WriteLine();
            while (continue_student)
            {
                continue_details = true;
                Console.WriteLine("which student would like to know more about? \nEnter a number 1-" + students.Count);

                if (!int.TryParse(Console.ReadLine(), out id) || id > students.Count)
                {
                    Console.WriteLine("The student does not exist; Please try again");
                    continue_student = true;
                }
                else
                {
                    //   Student student = students.Find(d => d.ID == id);
                    Student student = students[id - 1];
                    Console.WriteLine("Student " + id + " is " + student.Name);

                    while (continue_details)
                    {
                        Console.Write("What would you like to know about " + student.Name + "? ");
                        string detail = Console.ReadLine();
                        Console.WriteLine();
                        switch (detail.ToLower())
                        {
                            case "food":
                            case "eat":
                                Console.WriteLine(student.Name + " likes " + student.Food);
                                break;
                            case "hometown":
                            case "home":
                            case "town":
                            case "home-town":
                            case "home town":
                                Console.WriteLine(student.Name + " lives in " + student.HomeTown);
                                break;
                            default:
                                Console.WriteLine("Sorry, the data doesn't exist please enter \"hometown\" or \"food\"");
                                break;
                        }
                        Console.Write("Would you like to know more?(Y/N) : ");
                        string response = Console.ReadLine().ToLower();
                        continue_details = (response == "y"|| response == "yes");
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.Write("Would you like to know more students? (Y/N): ");
                    string response2 = Console.ReadLine().ToLower();
                    continue_student = (response2 =="y"|| response2 == "yes");
                    // continue_student = Console.ReadKey().Key == ConsoleKey.Y;
                    Console.WriteLine();

                }

            }

            Console.ReadKey();
        }
        static void fillStudent()
        {
            Student student;
            student = new Student(1, "Andrew Patenge", " Fremont", "steak");
            students.Add(student);
            student = new Student(2, "Chamus Gilbert", " Zeeland", "Sushi");
            students.Add(student);
            student = new Student(3, "David Wilkins", " Fort Wayne, IN", "Lasana");
            students.Add(student);
            student = new Student(4, "Aaron Sandusky", " Hart, MI", "Ribeye");
            students.Add(student);

            student = new Student(5, "Marshal James Hatley", " Holland, MI", "Burgers");
            students.Add(student);
            student = new Student(6, "Jonathan Andrew Higgins", " Middleville, MI", "Stouts");
            students.Add(student);
            student = new Student(7, "ALBERT SEVERIN NGOUDJOU", " Grand Rapis, MI", "pounded potatoes with beans");
            students.Add(student);
            student = new Student(8, "Adam Tasma", " Grand Rapis, MI", "putine");
            students.Add(student);
            student = new Student(9, "Tommy Waalkes", "Raleigh Nc", "Chicken Curry");
            students.Add(student);
            students.Add(new Student(10, "Ian TeGrootenhuis", "Allendale", "Alfredo"));
            students.Add(new Student(11, "Kevin Davis", "Chicago, Illinois", "Oatmeal"));
        }
        static public void showStudents()
        {
            Console.WriteLine("ID\tName");
            Console.WriteLine("----------------------------");
            foreach (Student item in students)
            {
                Console.WriteLine(item.ID + "\t" + item.Name);
                //  Console.WriteLine(item.ID +"\t"+item.Name+"\t"+ item.HomeTown+"\t"+item.Food);
            }
            Console.WriteLine();
        }
    }
}
