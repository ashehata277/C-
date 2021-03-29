using System;
using System.Reflection;
namespace myapp
{
    #region delegate
   /* public delegate int delegatemethods (out int x );
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                
                int OutofFunc;
                delegatemethods  delegatemethods1 = new delegatemethods(method1); 
                delegatemethods1 += method2;
                delegatemethods1 += method3;
                Console.WriteLine(delegatemethods1(out OutofFunc));
            }
            catch(Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
            finally
            {
                Console.WriteLine("From Finally");
            }
            
        }
        public static int method1 (out int x)
        {
            x=1;
            Console.WriteLine("From Method one{0} ");
            return 1; 
        }
        public static int method2 (out int x)
        {
            x=2;
            Console.WriteLine("From Method two {0}");
           
               return 2; 
        }
         public static int method3 (out int x)
        {
            x=3;
            Console.WriteLine("From Method three{0}");
         
               return 3; 
        }
        }*/
        #endregion
    #region Reflection
    /*class Customer
    {
        public int ID{ get;set; }
        public string name{get;set;}
        public Customer()
        {
            ID=0;
            name="";
        }
        public Customer(int id,string name)
        {
            this.ID=id;
            this.name=name;
        }
        public void print()
        {
            Console.WriteLine(ID.ToString()+name);
        }
    }
    class Program
    {
        
        static void Main()
        {
                Customer customer =  new Customer(){ID=1,name="Ahmed"};
                customer.print();
                Type t = Type.GetType("myapp.Customer");
                PropertyInfo[] properties = t.GetProperties();
                foreach(PropertyInfo i in properties)
                {
                    Console.WriteLine(i.PropertyType.Name+"/////////"+i.Name);
                }   
                    Console.WriteLine("=====================================");
                MethodInfo [] methods = t.GetMethods();  
                foreach(MethodInfo i in methods)
                {
                    Console.WriteLine(i.Name+"------------"+i.ReturnType.Name);
                }  

        }
    }*/
    #endregion
}
