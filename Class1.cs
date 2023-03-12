using System;
using System.Collections.Generic;
using System.Text;


namespace Consol_p
{
    public class Consol_projects
    {
        public int Project_Code;
        public string Project_ID;
        public string Consol_projects_ID;
        public string Project_Name;

        public int Project_Version
        {

            get { return Project_Version; }

            set { Project_Version = (value > 0 ? value : 1); }
        }

        int Project_Version;
        string Project_Description;

        public SampleClass()
        {
            Project_Version = 10;
            Project_Name = "name";
            Project_Description = "Project of the day";
        }

        public SampleClass(string value)
        {
            /// do something with the passed value
            Project_Description = value;
        }

        public Consol_projects()
        {
        }
        public Consol_projects(string Consol_projects_ID)
        {
        }
        public void RegisterProject(string Project_ID)
        {
        }
        public void RegisterProject(int Project_Code)
        {
        }
        public bool ProjectOnClass()
        {
        }

        public override string ToString()
        {
            return "Sample Class: " + Project_Version.ToString() +
                ", " + Project_Name + " " + "Project Description: " + Project_Description;
        }

        public void SampleMethod()
        {
            Console.WriteLine("You have successfully called a class method!");
        }

        /////


        public class List1<T>
        {
            public T data;
            public List1<T> next;
            private int length;

            public List1(T data)
            {
                this.data = data;
                this.next = null;
            }

            public int Length
            {
                get { return length; }
            }

        }

        public class LinkedList1<T>
        {
            private Node<T> head;

            public void AddFirst(T data)
            {
                Node<T> newNode = new Node<T>(data);
                newNode.next = head;
                head = newNode;
                length++;
            }

            public void AddLast1(T data)
            {
                Node<T> newNode = new Node<T>(data);

                if (head == null)
                {
                    head = newNode;
                    length++;
                    return;
                }

                Node<T> current = head;
                while (current.next != null)
                {
                    current = current.next;
                }

                current.next = newNode;
                length++;
            }

            public bool Remove(T data)
            {
                if (head == null)
                {
                    return false;
                }

                if (head.data.Equals(data))
                {
                    head = head.next;
                    length--;
                    return true;
                }

                Node<T> current = head;
                while (current.next != null)
                {
                    if (current.next.data.Equals(data))
                    {
                        current.next = current.next.next;
                        length--;
                        return true;
                    }

                    current = current.next;
                }

                return false;
            }

            public void PrintList("list1: ")
            {
                Node<T> current = head;
                while (current != null)
                {
                    Console.Write(current.data + " ");
                    current = current.next;
                }
                Console.WriteLine();
                Console.WriteLine("Length of the list: " + length);
            }

            LinkedList1<int> myList = new LinkedList1<int>();
            myList.AddFirst(1);
            myList.AddLast(2);
            myList.AddLast(3);
            myList.PrintList(); // output: 1 2 3
            myList.Remove(2);
            myList.PrintList(); // output: 1 3

            int min = myList.Min();
            Console.WriteLine("Minimum value: " + min);

            int max = myList.Max();
            Console.WriteLine("Minimum value: " + max);


            public class Program1
            {
                static void Main(string[] args)
                {
                    LinkedList<string> myList = new LinkedList<string>();
                    int length = 0

                    while (true)
                    {
                        Console.WriteLine("Enter an item to add to the list, or type 'quit' to exit:");
                        string input = Console.ReadLine();
                        length++;

                        if (input == "quit")
                        {
                            break;
                        }

                        myList.AddLast(input);
                        Console.WriteLine("Item added to the list.");
                        
                    }

                    Console.WriteLine("Final list ");
                    myList.PrintList();
                    Console.WriteLine("Length of the list: " + length);
                    

                }
            }


            ////

        }
    }

    public class Program2
    {
        public void Initialize()
        {
            Consol_projects ThisConsol_projects = new Consol_projects();
            Consol_projects AnotherConsol_projects = new Consol_projects("1222");
            ThisConsol_projects.RegisterProject("something");
            AnotherConsol_projects.RegisterProject(Project_Code: 1111);
            bool ProjectOnStatus = ThisConsol_projects.ProjectOnClass();
        }
    }
}
