using System.Collections.Immutable;

namespace ToDoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Anwendung: ToDo-List
            // Add, View, Delete, Quit

            string[] todoList = new string[5];

            int currentTaskCount = 0;

            string command = "";

            while (command != "quit")
            { 
                Console.WriteLine("Bitte gebe ein Kommando ein (add, view, delete, quit):");
                command = Console.ReadLine().ToLower();

                if (command == "add")
                {

                    if (currentTaskCount < todoList.Length)
                    {
                        Console.WriteLine("Trage Deine Notiz ein:");
                        todoList[currentTaskCount] = Console.ReadLine();
                        currentTaskCount++;
                    }
                    else
                    {
                        Console.WriteLine("Deine ToDo-Liste ist leider schon voll!");
                    }

                }
                else if (command == "view")
                {
                    Console.WriteLine("Deine ToDo-Liste:");

                    for (int i = 0; i < currentTaskCount; i++)
                    {
                        Console.WriteLine((i + 1) + ". " + todoList[i]);
                    }

                }
                else if(command == "delete")
                {
                    Console.WriteLine("Nenne die Nummer der zu löschenden Aufgabe:");
                    int deleteNumber = int.Parse(Console.ReadLine()) -1;

                    if (deleteNumber < 0 || deleteNumber >= currentTaskCount)
                    {
                        Console.WriteLine("Ungültige Eingabe!");

                    }
                    else if (deleteNumber == todoList.Length - 1)
                    {
                        todoList[deleteNumber] = "";
                        currentTaskCount--;

                    }
                    else
                    {
                        for (int i = deleteNumber; i < currentTaskCount; i++)
                        {
                            todoList[i] = todoList[i + 1];
                        }

                        if (currentTaskCount > 1)
                        {
                            currentTaskCount--;
                        }
                        else
                        {
                            currentTaskCount = 0;
                        }

                    }

                }

            }

        }
    }
}
