using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace myapp
{
    class Program
    {
        static void Main()
        {
            #region Where
            Student [] students  = {
                new Student {ID=1,Name="Ahmed",Age=23},
                new Student {ID=2,Name="Arwa",Age=24},
                new Student {ID=5,Name="Aya",Age=27},
                new Student {ID=4,Name="Omnia",Age=20},
                new Student {ID=3,Name="Aml",Age=56},
                new Student {ID=6, Name="Omar",Age=24},
                new Student {ID=10,Name="Mostafa",Age=24},
                new Student {ID=7, Name="Ali",Age=24},
                new Student {ID=8, Name="Ali",Age=24}
            };
            //Func<Student,bool> TraverseItem  = delegate (Student s){return s.Age>25;}; 
            Func<Student,bool> TraverseItem = (Student s)=>{return s.Age>25;}; 
            var Result = from s in students where TraverseItem(s) select s;
            foreach(var item in Result)
            {
                Console.WriteLine(item.ID +"----"+item.Name+"------"+item.Age);
            }
            #endregion
            #region mixedLists
            ArrayList mixed  = new ArrayList();
            mixed.Add(1);
            mixed.Add(2);
            mixed.Add("one");
            mixed.Add("two");
            mixed.Add(students[0]);
            var Result1  = from s in mixed.OfType<String>() select s;
            foreach(var item in Result1)
            {
                Console.WriteLine(item);
            }
            var Result_Student =  from s in mixed.OfType<Student>() select s;
            foreach(var item in Result_Student)
            {
                Console.WriteLine(item.ID+"---"+item.Name+"-------"+item.Age);
            }     
            #endregion
            #region Order
            var OrderResult = from s in students orderby s.Name descending,s.ID descending /*descending*/ select s;
             foreach(var item in OrderResult)
            {
                Console.WriteLine(item.ID +"----"+item.Name+"------"+item.Age);
            }
            #endregion
            #region  GroupBy
            var GroupResult = from s in students group s by s.Age ;
            foreach(var item in GroupResult)
            {
                Console.WriteLine(item.Key);
                foreach(var ageItem in item )
                {
                    Console.WriteLine(ageItem.ID+ageItem.Name+ageItem.Age);
                }
                Console.WriteLine("-------------------------------");
            }
            #endregion
            #region join
            Student[] standard = {
                new Student(){ID=1,Name="Standard",Age=28},
                new Student(){ID=2,Name="Standard",Age=28},
                new Student(){ID=3,Name="Standard",Age=28}
            };
            var joinResult = from s in students join st in standard on s.ID equals st.ID select new {
                StudentName = s.Name, StandardName=st.Name
            };
            foreach(var item in joinResult)
            {
                Console.WriteLine(item.StudentName+"-------------"+item.StandardName);
            }    
            #endregion
            #region Conatins
            IList<Student> studentList = new List<Student>() { 
                new Student {ID=1,Name="Ahmed",Age=23},
                new Student {ID=2,Name="Arwa",Age=24},
                new Student {ID=5,Name="Aya",Age=27},
                new Student {ID=4,Name="Omnia",Age=20},
                new Student {ID=3,Name="Aml",Age=56},
                new Student {ID=6, Name="Omar",Age=24},
                new Student {ID=10,Name="Mostafa",Age=24},
                new Student {ID=7, Name="Ali",Age=24},
                new Student {ID=8, Name="Ali",Age=24}
            };
            Student Comparator = new Student(){ID=1,Name="Ahmed",Age=24};
            bool Comparsion= studentList.Contains<Student>(Comparator,new StudentComparer());
            Console.WriteLine(Comparsion);
            #endregion
            
        }
    }
    class Student
    {
        public int ID {set;get;}
        public string Name {set;get;}
        public int Age {set;get;}
    }
    class StudentComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            if(((Student)x).ID == ((Student)y).ID && ((Student)x).Name.ToUpper()==((Student)y).Name.ToUpper() )
                return true;
            return false;
        }

        public int GetHashCode(Student obj)
        {
            return obj.GetHashCode();
        }
    }
}