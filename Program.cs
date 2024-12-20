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
        List<TaskItem> tasks = new List<TaskItem>(); // pusta lista, bedzie przechowywac obiekty taskitem
     
       while (true) // petla w nieskonczonosc, powoduje ze moj program bedzie działał do momentu przerwania "break" czyli po ukonczeniu z listy ostaniego zadania 
    {  
         Console.WriteLine("To Do List: \n1.  Add a task \n2. View a task \n3. Exit"); // menu uzytkownika 
        Console.Write(" Choose an option:");
       
       string choice = Console.ReadLine(); // zmienna string przechowuje dane od uzytkownika choice nazwa nadana przeze mnie, dzieje sie to za pomocą przypisania do funkcji console.readline

       if (choice == "1") // wyswietlane komunikaty w zaleznosci od wyboru uzytkownika 
       
       {
        
        Console.Write("Enter task description");
       string description = Console.ReadLine(); // odczytuje wprowadzony przez uzytkownika zapis
       TaskItem newTask = new TaskItem(description);  // tworzy nowy obiekt TaskItem z podanym opisem
        tasks.Add(newTask); //   // dodaje nowo utworzony obiekt TaskItem do listy tasks
        Console.WriteLine("Task added");
       }


       else if (choice == "2") // opcja przeglądania zadań 

{
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks available.");
        }
        else 
        {
            Console.WriteLine("Tasks:");

            for (int i = 0; i < tasks.Count; i++) // pętla for-pozwala na wielokrotne wykonanie określonego bloku kodu, gdy spełniony jest określony warunek (inicjalizacja; warunek; inkrementacja)
            {
                var task = tasks[i]; // pobieram element z listy tasks o indeksie i i przypisuje go do zmiennej task, var, kompilator automatycznie okresli typ zmiennej na podstawie przypisanej wartosci
                string status = task.IsCompleted ? "[Completed]" : "[Not Completed]"; // uzywam operatora warunkowego do przypisania wartosci do zmiennej status, check czy wlasciwosc IsCompleted obiektu task jest true(completed) czy false(not completed)
                Console.WriteLine($"{i +1}. {task.TaskDescription} {status}"); // wyswietlenie informacji o zadaniu w formacie: numer, opis, status, {i + 1}: dodaje 1 do indeksu i - numeracja zadan zaczyna sie od 1, indeksy w liscie od 0, {task.TaskDescription}: opis zadania, odwolujac sie do wlasciwosci TaskDescription obiektu task, status okreslony w poprzedniej linii
            }
        }
    

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

