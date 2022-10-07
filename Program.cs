using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using Ganss.Excel;


namespace StudentApplication1
{
    
    public static class Program
    {
        static List<Student> student_list = new List<Student>();
        static void Main(string[] args)
        {

            //bool showMenu = true;

            //initialise list with few data
            Student student1 = new Student("nikita", 1, "EC");
            student_list.Add(student1);
            Student student2 = new Student("jack", 2, "EC");
            student_list.Add(student2);
          

            try
            {
                if (student_list == null)
                    throw new CustomException("no student record present i.e student list is empty");
                Menu.MainMenu(student_list);

     
            }
            catch (CustomException message)
            {
                WriteLine(message.Message);
            }
        }
      
    }
}
