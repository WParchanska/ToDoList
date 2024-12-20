using System; // nazwy przestrzeni, które będe uzywac w mojej aplikacji
using System.Collections.Generic;

class TaskItem // klasa taskitem, pozwoli przechowywać zarówno opis zadania, jak i jego status, przed main 
{
    public string TaskDescription { get; set; } // opis zadania /string- typ danych;lancuch znakow, taskdescription-identyfikator do odnoszenia sie w kodzie, get,set automatycznie implementowana wlasciwosc; metody ktore odczytuja i ustawiaja wartosc tej wlasciowosci 
    public bool IsCompleted { get; set; } // Status zadania (zrobione/niezrobione)/ w klasie TaskItem właściwość o nazwie IsCompleted, która pełni określoną rolę w zarządzaniu stanem zadania bool - typ danych zwraca true or false

    public TaskItem(string description)
    {
        TaskDescription = description;
        IsCompleted = false;
    }
}

public class Program // stworzona klasa program, grupuje kod w logike
{
    private static void Main(string[] args) // metoda main, punkt startowy mojego programu, void oznacza ze nie zwraca wartosci 
    {
        List<TaskItem> tasks = new List<TaskItem>();
     
       while (true) // petla w nieskonczonosc, powoduje ze moj program bedzie działał do momentu przerwania "break" czyli po ukonczeniu z listy ostaniego zadania 
    {  
         Console.WriteLine("To Do List: \n1.  Add a task \n2. View a task \n3. Exit"); // menu uzytkownika 
        Console.Write(" Choose an option:");
       
       string choice = Console.ReadLine(); // zmienna string przechowuje dane od uzytkownika choice nazwa nadana przeze mnie, dzieje sie to za pomocą przypisania do funkcji console.readline

       if (choice == "1") // wyswietlane komunikaty w zaleznosci od wyboru uzytkownika 
       
       {
        
        Console.Write("Enter task description");
       string description = Console.ReadLine();
       TaskItem newTask = new TaskItem(description);  // Tworzymy nowy obiekt TaskItem z podanym opisem
        tasks.Add(newTask); //   // Dodajemy nowo utworzony obiekt TaskItem do listy tasks
        Console.WriteLine("Task added");
       }


       else if (choice == "2")

{

    Console.WriteLine(" You chose to view tasks");

}

else if (choice == "3")

{

    Console.WriteLine("Goodbye!");

}

else

{

    Console.WriteLine("Invalid choice. Please try again.");

    
    }
       
        
      
}

       }
        
    }

