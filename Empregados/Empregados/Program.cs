using System;
using System.Collections.Generic;
using Empregados.Entities;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empregados
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Informe o número de empregados: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {

                /*
                 * interpolação de variavel 
                 * necessário usar o $ e o # antes da variavel
                 */

                Console.WriteLine($"Empregado #{i}: ");
                Console.Write("Terceirazado (s/n): ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Horas: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Informe o valor hora: ");
                double valuehours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'y' || ch == 'Y')
                {
                    Console.Write("Informe o custo adicional: ");
                    double additionalcharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsorcingEmployee(name, hours, valuehours, additionalcharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuehours));
                }


            }

            Console.WriteLine();
            Console.WriteLine("Pagamemto");

            foreach (Employee emp in list)
            {
                Console.WriteLine(emp.Name + " - R$ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }


        }
    }
}
