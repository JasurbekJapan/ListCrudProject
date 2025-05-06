using CRUD.Models;
using CRUD.Services;
using CRUD.Services.Interface;

class Program
{
    static void Main(string[] args)
    {
        RegisterService registerService = new RegisterService();
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View All Students");
            Console.WriteLine("3. Update Student");
            Console.WriteLine("4. Delete Student");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    
                    Console.Write("Enter First Name: ");
                    string firstName = Console.ReadLine();
                    Console.Write("Enter Last Name: ");
                    string lastName = Console.ReadLine();
                    Console.Write("Enter Age: ");
                    int age = int.Parse(Console.ReadLine());
                    Console.Write("Enter Group Name: ");
                    string groupName = Console.ReadLine();
                    Students student = new Students
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        GroupName = groupName
                    };
                    registerService.AddStudent(student);
                    Console.WriteLine("Student added successfully.");
                    break;
                case 2:
                    List<Students> students = registerService.GetAllStudents();
                    Console.WriteLine("All Students:");
                    if(students.Count() == 0)
                    {
                        Console.WriteLine("Students Not Found!");
                    }
                    Console.WriteLine("All Students: ");
                    foreach (var stud in students)
                    {
                        Console.WriteLine($"Id: {stud.Id}, Name: {stud.FirstName}, Surname: {stud.LastName}, Age: {stud.Age}, Group: {stud.GroupName}");
                    }
                    break;
                case 3:
                    Console.Write("Enter Student Id to update: ");
                    int updateId = int.Parse(Console.ReadLine());
                    Students studentToUpdate = registerService.GetStudentById(updateId);
                    if (studentToUpdate == null)
                    {
                        Console.WriteLine("Student not found.");
                        break;
                    }

                    Console.WriteLine("1. First Name");
                    Console.WriteLine("2. Last Name");
                    Console.WriteLine("3. Age");
                    Console.WriteLine("4. Group Name");
                    Console.WriteLine("5. All");
                    Console.Write("options: ");
                    int UptadeOption = int.Parse(Console.ReadLine());

                    switch (UptadeOption)
                    {
                        case 1:
                            Console.Write("Enter new First Name: ");
                            studentToUpdate.FirstName = Console.ReadLine();
                            break;
                        case 2:
                            Console.Write("Enter new Last Name: ");
                            studentToUpdate.LastName = Console.ReadLine();
                            break;
                        case 3:
                            Console.Write("Enter new Age: ");
                            studentToUpdate.Age = int.Parse(Console.ReadLine());
                            break;
                        case 4:
                            Console.Write("Enter new Group Name: ");
                            studentToUpdate.GroupName = Console.ReadLine();
                            break;
                        case 5:
                            Console.Write("Enter new First Name: ");
                            studentToUpdate.FirstName = Console.ReadLine();
                            Console.Write("Enter new Last Name: ");
                            studentToUpdate.LastName = Console.ReadLine();
                            Console.Write("Enter new Age: ");
                            studentToUpdate.Age = int.Parse(Console.ReadLine());
                            Console.Write("Enter new Group Name: ");
                            studentToUpdate.GroupName = Console.ReadLine();
                            break;
                        default:
                            Console.WriteLine("Invalid Choice");
                            break;
                    }

                    registerService.UpdateStudent(studentToUpdate);
                    Console.WriteLine("Student Update successfully!");
                    break;
                case 4:

                    Console.Write("Enter Student Id to delete: ");
                    int deleteId = int.Parse(Console.ReadLine());
                    bool isDeleted = registerService.DeleteStudent(deleteId);
                    if (isDeleted)
                    {
                        Console.WriteLine("Student deleted successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Student not found.");
                    }
                    break;
                case 5:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }   
}