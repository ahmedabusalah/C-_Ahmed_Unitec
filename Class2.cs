using System;
using System.Collections.Generic;
using System.Text;


namespace GUI_1
{
    public class GUI
    {

        public string GUI_ID;
        public string Form_ID;
        public string GUI_Name;
        public string GUI_Title;
        public string GUI_Help;
        public string Windows_Forms;


        public int Form_Code
        {

            get { return Form_Code; }

            set { Form_Code = (value > 0 ? value : 1); }
        }

        int Form_Code;
        string GUI_Description;

        public SampleClass2()
        {
            Form_Code = 1;
            GUI_Name = "name2";
            GUI_Description = "GUI of the day2";
        }

        public SampleClass2(string value)
        {

            GUI_Description = value;
        }

        public GUI()
        {
        }
        public GUI(string GUI_ID)
        {
        }
        public void RegisterForm(string Form_ID)
        {
        }
        public void RegisterForm(int Form_Code)
        {
        }
        public bool GUIOnClass()
        {
        }

        public override string ToString()
        {
            return "Sample Class2: " + Form_Code.ToString() +
                ", " + GUI_Name + " " + "GUI Description: " + GUI_Description;
        }

        public void SampleMethod()
        {
            Console.WriteLine("You have successfully called a class method2!");
        }

        ////

        public class List2<T>
        {
            public T data;
            public List2<T> next;

            public List2(T data)
            {
                this.data = data;
                this.next = null;
            }
        }

        public class LinkedList2<T>
        {
            private Node<T> head;

            public void AddFirst(T data)
            {
                Node<T> newNode = new Node<T>(data);
                newNode.next = head;
                head = newNode;
            }

            public void AddLast2(T data)
            {
                Node<T> newNode = new Node<T>(data);

                if (head == null)
                {
                    head = newNode;
                    return;
                }

                Node<T> current = head;
                while (current.next != null)
                {
                    current = current.next;
                }

                current.next = newNode;
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
                    return true;
                }

                Node<T> current = head;
                while (current.next != null)
                {
                    if (current.next.data.Equals(data))
                    {
                        current.next = current.next.next;
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
            }

            LinkedList2<int> myList = new LinkedList2<int>();
            myList.AddFirst(1);
            myList.AddLast(2);
            myList.AddLast(3);
            myList.PrintList(); // output: 1 2 3
            myList.Remove(2);
            myList.PrintList(); // output: 1 3


            public class Program3
            {
                static void Main(string[] args)
                {
                    LinkedList<string> myList = new LinkedList<string>();

                    while (true)
                    {
                        Console.WriteLine("Enter an item to add to the list, or type 'quit' to exit:");
                        string input = Console.ReadLine();

                        if (input == "quit")
                        {
                            break;
                        }

                        myList.AddLast(input);
                        Console.WriteLine("Item added to the list.");
                    }

                    Console.WriteLine("Final list (input): ");
                    myList.PrintList();
                }
            }

            ////

        }
    }   
    public class Program4
    {
        public void Initialize()
        {
            GUI ThisConsol_projects = new GUI();
            GUI AnotherGUI = new GUI("1222");
            ThisGUI.RegisterForm("something");
            AnotherGUI.RegisterForm(Form_Code: 1111);
            bool GUIOnStatus = ThisGUI.GUIOnClass();
        }
    }
}