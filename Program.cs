using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentChooserApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] allStudents = {"Agapii Marius", "Apreutesei Iulian", "Badan Marius", "Baranovschi Valentin", 
            "Braga Dumitru", "Calugher Marcela", "Cerescu Dan", "Ciobanu Daniel", "Clepalo Vladislav", 
            "Codrean Gabriel-David", "Constantinov Dumitru", "Crijanovschi Nicolae", "Croitor Gheorghe",
            "Digori Antonie", "Enachi Valentin", "Gheorghița Ionuț", "Gheorghița Mihai", "Gînga Daniil",
            "Gînu Ion", "Goldur Dionisie", "Harabari Eugeniu", "Lungu Cătălin", "Lungu Stanislav",
            "Neteda Octavian", "Roșca Marian", "Rotaru Nicolae", "Rusu Vladislav", "Secrieru Dragoș",
            "Șmatoc Artiom", "Tiulenev Ion", "Vrabie Corneliu"};
            List<string> selectedStudents = new List<string>();

            Console.Write("Enter the number of students to select: ");
            int numStudents = int.Parse(Console.ReadLine());

            Random rnd = new Random();
            List<string> availableStudents = allStudents.ToList();

            for (int i = 0; i < numStudents; i++)
            {
                int index = rnd.Next(availableStudents.Count);
                selectedStudents.Add(availableStudents[index]);
                availableStudents.RemoveAt(index);
            }

            selectedStudents.Sort();
            Console.WriteLine("Selected students:");
            foreach (string student in selectedStudents)
            {
                Console.WriteLine(student);
            }
        }
    }
}
