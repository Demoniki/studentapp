using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace StudentApplication1
{
    public class CrudOperations
    {
        //ADD
        public static void AddRecord(List<Student> student_list, int numOfRecords)
        {
            try
            {
                if (numOfRecords <= 0)
                {
                    throw new CustomException("Number of records cant be negative give a positive integer");
                }
                for (int i = 0; i < numOfRecords; i++)
                {
                    WriteLine("Enter the student Name:");
                    string name = ReadLine();
                    WriteLine("Enter the student Id:");
                    int id = Convert.ToInt32(ReadLine());
                    WriteLine("Enter the student Branch");
                    string branch = ReadLine();
                    Student member = new Student(name, id, branch);

                    if (student_list[i].Id != member.Id)
                    {
                        student_list.Add(member);
                        WriteLine("record added successfully");
                    }
                    else
                    {
                        throw new CustomException("Record already exist cant add");
                    }

                }
            }
            catch (CustomException message)
            {
                WriteLine(message.Message);
            }

        }
        //DELETE a record 
        public static void deleteRecord(List<Student> student_list, int target)
        {
            try
            {

                if (student_list.Count == 0)
                {
                    throw new CustomException("No records present- List is Empty");
                }
                WriteLine("enter rocord of students which you want to delete");
                WriteLine("enter the name :");
                string name = ReadLine();
                WriteLine("enter the branch :");
                string branch = ReadLine();
                WriteLine("enter the id :");
                int id = Convert.ToInt32(ReadLine());

                Student del_Student = new Student(name, id, branch);
                int index = student_list.FindIndex(x => x.Id == del_Student.Id);
                student_list.RemoveAt(index);

                if (index == -1)
                {
                    throw new CustomException("No record matches the given ID");
                }
            }
            catch (CustomException message)
            {
                WriteLine(message.Message);
            }

        }

        //UPDATE record 
        public static void updateStudent(List<Student> student_list)
        {
            try
            {
                WriteLine("enter the name :");
                string name = ReadLine();

                WriteLine("enter the branch :");
                string branch = ReadLine();

                WriteLine("enter the id :");
                int id = Convert.ToInt32(ReadLine());
                Student update_Student = new Student(name, id, branch);

                int index = student_list.FindIndex(x => x.Id == update_Student.Id);

                if (index == -1)
                {
                    throw new CustomException("No record match this ID");
                }
                WriteLine("enter the correct name");
                string data = ReadLine();
                student_list[index].Name = data;
                WriteLine("Record updated successfully");
            }
            catch (CustomException message)
            {
                WriteLine(message.Message);
            }

        }



        // DISPLAY
        public static void Display(List<Student> student_list)
        {

            if (student_list.Count == 0)
            {
                throw new CustomException("No records present-List is Empty");
            }

            foreach (Student student in student_list)
            {
                WriteLine(student.Id + " " + student.Name + " " + student.Branch);
            }
        }

    }
}
