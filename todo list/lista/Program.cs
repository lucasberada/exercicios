using System;
using System.Collections.Generic;
using System.IO;

namespace lista
{
    class Program
    {
        static void Main(string[] args)
        {

            List<TodoItem> todolist =new List<TodoItem>();
            string filename = "todo.csv";
            string filepath = ".\\" + filename;

            try {
                 string[] TodoFile= File.ReadAllLines(filepath);

                 foreach (string line in TodoFile)
                 {
                    string [] itens= line.Split(",");
                    string titulo= itens[0].Replace("\"", "");
                    string  nota =itens[1].Replace("\"", "");

                    TodoItem todoitem =new TodoItem(titulo,nota);
                    todolist.Add(todoitem);


                 }
            }catch (IOException ioe) {
                    System.Console.WriteLine("erro ao acessar arquivo");
                    System.Console.WriteLine(ioe.Message);

            }

            int opcao =0;

            do{
                Console.Clear();
                System.Console.WriteLine("todolist");
                System.Console.WriteLine();
                ListaItems(todolist);
                System.Console.WriteLine();
                System.Console.WriteLine("digite uma opcao");
                System.Console.WriteLine("1-adicionar item");
                System.Console.WriteLine("2-remover  item");
                System.Console.WriteLine("3-sair do programa");
                System.Console.WriteLine("opção: ");
                opcao =int.Parse(Console.ReadLine());

                switch(opcao)
                {
                    case 1:
                        AddItem(todolist);
                    
                

                    break;

                    case 2:
                        removeItem(todolist);

                    break;

                    case 3:
                    Console.WriteLine("tchau!");

                    break;

                    default:
                    System.Console.WriteLine("opção invalida");
                    Console.ReadLine();
                    
                    break;
                }

            }while(opcao !=3);

        }

        public static void ListaItems(List<TodoItem> todolist)
        {
            Console.Clear();
            int count = 1;
            System.Console.WriteLine("todo list");
            System.Console.WriteLine();
            System.Console.WriteLine($"ID{"",2} titulo {"",12} notas ");
            foreach (TodoItem item in todolist)
            {
                System.Console.WriteLine($"{count, 3} : {item.titulo,-15} - {item.Nota, -15}");
                count ++;
            }
        }

        public static void AddItem(List<TodoItem> todolist)
        {
            Console.Clear();
            System.Console.WriteLine("todo list: ");
            System.Console.WriteLine();
            System.Console.WriteLine("titulo : ");
            string titulo = Console.ReadLine();
            System.Console.WriteLine("nota: ");
            string nota = Console.ReadLine();
            TodoItem item = new TodoItem (titulo, nota);

            todolist.Add(item);

        }

        public static void removeItem(List<TodoItem> todolist)
        {
            int index = 0;
            do{
                Console.Clear();
                System.Console.WriteLine("reomve item");
                System.Console.WriteLine();
                ListaItems(todolist);
                System.Console.WriteLine();
                System.Console.WriteLine("digite o id ou x para terminar");
                System.Console.Write("id: ");
                string id =Console.ReadLine();

                if (id.ToLower() == "x")
                {
                    break;
                }
                else
                {
                    index =int.Parse(id) -1;
                }

                if(index <0 || (index > todolist.Count - 1))
                {
                    System.Console.WriteLine("id invalido");
                    System.Console.WriteLine("pressione <enter> para continuar");
                    Console.ReadLine();
                }else{
                    todolist.RemoveAt(index);
                }

            } while (true);
        }
    }
}
