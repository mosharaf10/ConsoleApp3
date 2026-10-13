using System.Collections.Specialized;
using System.Globalization;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array
            /* string[] studentsArray = [ "Ahmed", "Sara", "Mona" ];
             List<string> studentsList = [];
             studentsList.Add(studentsArray[0]);
             studentsList.Add(studentsArray[1]);
             studentsList.Add(studentsArray[2]);
             Console.WriteLine(studentsList[2]);
             Console.WriteLine(studentsList[studentsArray.Length-1]);
             Console.WriteLine(studentsList.Count);
            */



            // 2) List
            /* List<string> studentsList = [];

             studentsList.Add("Ahmed");
             studentsList.Add("Sara");
             studentsList.Add("Mona");

              Console.WriteLine(studentsArray[studentsArray.Length - 1]);
              Console.WriteLine(studentsList[studentsList.Count - 1]);


           /*  // 3) LinkedList
             LinkedList<string> studentsLinked = [];
             LinkedList<string> studentsLinkedList = new(); 
             studentsLinkedList.AddLast("Ahmed");
             studentsLinkedList.AddLast("Sara");
             studentsLinkedList.AddLast("Mona");
             // TODO: Add 3 names manually

             // 4) Dictionary
             Dictionary<string, string> studentsDict = [];

             studentsDict.Add("Ahmed", "Active");
             studentsDict.Add("Sara", "In Active");
             studentsDict.Add("Mona", "Active");
             // TODO: Add 3 key-value pairs manually (Name -> "Active", "In Active")

             // 5) Print (no loops)
             Console.WriteLine("Array:");
             Console.WriteLine(studentsArray[0]);
             Console.WriteLine(studentsArray[1]);
             Console.WriteLine(studentsArray[2]);

             // TODO: Print elements manually (studentsArray[0], ...)

             Console.WriteLine("\nList:");
             Console.WriteLine("\nList:");
             Console.WriteLine(studentsList[0]);
             Console.WriteLine(studentsList[1]);
             Console.WriteLine(studentsList[2]);
             // TODO: Print elements manually

             Console.WriteLine("\nLinkedList:");
             // TODO: Print elements manually (First, Next, Last)

             Console.WriteLine("\nDictionary:");
             // TODO: Print key-value pairs manuall*/


            //LinkedList
            /*LinkedList<int> list = new LinkedList<int>();
            list.AddLast(10);
            LinkedListNode<int>node_1=list.AddLast(20);
            list.AddFirst(30);
            list.AddLast(40);
            list.AddAfter(node_1, 50);
            Console.WriteLine(list.ElementAt(0));
            Console.WriteLine(list.ElementAt(1));
            Console.WriteLine(list.ElementAt(2));
            Console.WriteLine(list.ElementAt(3));
            Console.WriteLine(list.ElementAt(4));//30,10,20,50,40*/


            //Dictionary
            /*  Dictionary<String, List<String>> D = new Dictionary<string, List<string>>();
              List<string> phones = new List<string>();
              phones.Add("01016490828");
              phones.Add("01016490827");
              D["sharaf"] = phones;
              Console.WriteLine(D["sharaf"][0]);
              Console.WriteLine(D["sharaf"][1]);

              D["ali"] = "01016490828";
              D["samy"] = "01016490827";
              D["hany"] = "01016490826";
              Console.WriteLine(D["ali"]);
              Console.WriteLine(D["samy"]);*/

            //stack
            /*Stack<int> my_stack = new Stack<int>();
            my_stack.Push(1);
            my_stack.Push(2);
            my_stack.Push(3);
            Console.WriteLine(my_stack.Pop());
            Console.WriteLine(my_stack.Peek());

            //queue
            Queue<int> my_queue = new Queue<int>();
            my_queue.Enqueue(1);
            my_queue.Enqueue(2);
            my_queue.Enqueue(3);
            my_queue.Dequeue();
            Console.WriteLine(my_queue.Peek()) ;*/


            //Console.WriteLine(5==6);



            /*int calc = 0;
            
            for(int i = 1; i <= 15; i+=2)
            {
                calc += i;
            }
            Console.WriteLine(calc);*/

            /* double cost = 2.5;
             Console.WriteLine("Base cost =$2.5");
             Console.WriteLine("Enter your dimensial");
             Console.WriteLine("Enter lenght :");
             int lenght = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter width :");
             int width = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter height :");
             int height = Convert.ToInt32(Console.ReadLine());
             int size = lenght * width * height;

             if (size > 500)
             {


                 Console.WriteLine("Size>500.so,There is 25% surcharge");
                 cost = .25 * cost + cost;
                 Console.WriteLine($"cost= ${cost}");

             }
             else if (size > 100)
             {
                 Console.WriteLine("Size>100.so,There is 10% surcharge");
                 cost = .1 * cost + cost;
                 Console.WriteLine($"cost= ${cost}");
             }

             else
             {
                 Console.WriteLine($"cost= ${cost}");

             }*/
            /* int numcount = Console.ReadLine();
             int[] arr = new int[numcount];
             arr[i] = Console.ReadLine();
             int max=0;
             for (int i = 0; i <= num1; i++)
             {
                 if (max > arr[i])
                 {
                     max = arr[i];

                 }
             }
             Console.WriteLine(max);*/
            string name = Console.ReadLine();
            int age = Convert.ToInt32(Console.ReadLine());
            info(name, age);
      
        }
        
         static void info(string name,int age)
        {
            Console.WriteLine("my name is "+name);
            Console.WriteLine("my age is "+age);

        }
    }


}
