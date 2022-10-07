using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplication1
{
    [Serializable]
    public class Student
    {

        private string name;
        private int id;
        private string branch;
        //parameterised constructer 
        public Student(string name, int id, string branch)
        {
            this.name = name;
            this.id = id;
            this.branch = branch;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Branch
        {
            get { return branch; }
            set { branch = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

    }
}
