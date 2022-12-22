namespace OOP_Lab_8_collection_generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Stack<Employee> EmploStack = new Stack<Employee>();

            Employee E1 = new Employee() { EmployeeId = 1, FirstName = "Lars", LastName = "Stromqvist", Gender = "M", Age = 55, Salary = 40000 };
            Employee E2 = new Employee() { EmployeeId = 2, FirstName = "Anna", LastName = "Karlsson", Gender = "S", Age = 52, Salary = 41000 };
            Employee E3 = new Employee() { EmployeeId = 3, FirstName = "Joakim", LastName = "Johansson", Gender = "M", Age = 53, Salary = 42000 };
            Employee E4 = new Employee() { EmployeeId = 4, FirstName = "Sara", LastName = "Larsson", Gender = "S", Age = 54, Salary = 43000 };
            Employee E5 = new Employee() { EmployeeId = 5, FirstName = "Tor", LastName = "Hammar", Gender = "M", Age = 65, Salary = 44000 };
            Employee E6 = new Employee() { EmployeeId = 6, FirstName = "Sibyll", LastName = "Jonsson", Gender = "S", Age = 62, Salary = 45000 };

            Stack<Employee> EmploStack = new Stack<Employee>();

            EmploStack.Push(E1);
            EmploStack.Push(E2);
            EmploStack.Push(E3);
            EmploStack.Push(E4);
            EmploStack.Push(E5);
            EmploStack.Push(E6);

            Console.WriteLine("Items left in stack:" + EmploStack.Count);

            foreach (var Employee in EmploStack)
            {
                Console.WriteLine("Employee");
                Console.WriteLine("Items left in stack:" + EmploStack.Count);
                //Console.WriteLine(value: $"EmployeeId={EmploStack.EmployeeId} FirstName={EmploStack.FirstName} LastName={EmploStack.LastName} Gender={EmploStack.Gender} Age={EmploStack.Age} Salary= {EmploStack.Salary}");
            }
            Console.WriteLine("");


            {
                //Employee = EmploStack.Pop();
                //Console.WriteLine(.FirstName);
                //Console.WriteLine("Items left in stack:" + EmploStack.Count);

                Employee ES1 = EmploStack.Pop();
                Console.WriteLine($"EmployeeId={E1.EmployeeId} FirstName={E1.FirstName} LastName={E1.LastName}Gender={E1.Gender} Salary= {E1.Salary}");
                Console.WriteLine("items kvar i stacken:" + EmploStack.Count);

                Employee ES2 = EmploStack.Pop();
                Console.WriteLine($"EmployeeId={E2.EmployeeId} FirstName={E2.FirstName} LastName={E2.LastName}Gender={E2.Gender} Salary= {E2.Salary}");
                Console.WriteLine("items kvar i stacken:" + EmploStack.Count);

                Employee ES3 = EmploStack.Pop();
                Console.WriteLine($"EmployeeId={E1.EmployeeId} FirstName={E3.FirstName} LastName={E3.LastName}Gender={E3.Gender} Salary= {E3.Salary}");
                Console.WriteLine("items kvar i stacken:" + EmploStack.Count);

                Employee ES4 = EmploStack.Pop();
                Console.WriteLine($"EmployeeId={E4.EmployeeId} FirstName={E4.FirstName} LastName={E4.LastName}Gender={E4.Gender} Salary= {E4.Salary}");
                Console.WriteLine("items kvar i stacken:" + EmploStack.Count);

                Employee ES5 = EmploStack.Pop();
                Console.WriteLine($"EmployeeId={E5.EmployeeId} FirstName={E5.FirstName} LastName={E5.LastName}Gender={E5.Gender} Salary= {E5.Salary}");
                Console.WriteLine("items kvar i stacken:" + EmploStack.Count);

                Employee ES6 = EmploStack.Pop();
                Console.WriteLine($"EmployeeId={E6.EmployeeId} FirstName={E6.FirstName} LastName={E6.LastName}Gender={E6.Gender} Salary= {E6.Salary}");
                Console.WriteLine("items kvar i stacken:" + EmploStack.Count);

                Console.WriteLine("");

                {

                    EmploStack.Push(E1);
                    EmploStack.Push(E2);
                    EmploStack.Push(E3);
                    EmploStack.Push(E4);
                    EmploStack.Push(E5);
                    EmploStack.Push(E6);

                    Console.WriteLine("");
                }
                {
                    Employee ES = EmploStack.Peek();
                    Console.WriteLine("Items left in stack:" + EmploStack.Count);
                    Employee EP = EmploStack.Peek();
                    Console.WriteLine("Items left in stack: " + EmploStack.Count);
                }
                Console.WriteLine("");
                {
                    if (EmploStack.Contains(E1) == true)
                    {
                        Console.WriteLine("Employee 1 is in the stack");
                    }
                    else
                    {
                        Console.WriteLine("Employee 1 is not in the stack");
                    }
                    Console.WriteLine("");
                    {
                        List<Employee> EmploList = new List<Employee>();
                        EmploList.Add(E1);
                        EmploList.Add(E2);
                        EmploList.Add(E3);
                        EmploList.Add(E4);
                        EmploList.Add(E5);

                        if (EmploList.Contains(E1) == true)
                        {
                            Console.WriteLine("Employee 1 exists in the list");
                        }
                        else
                        {
                            Console.WriteLine("Employee 1 is not in the list");
                        }
                        Console.WriteLine("");

                        var findAll = EmploList.FindAll(i => i.Gender == "M");
                        foreach (var item in findAll) 
                        {
                            Console.WriteLine(item);
                        }

                    }
                }
            }
        }
    }
}
