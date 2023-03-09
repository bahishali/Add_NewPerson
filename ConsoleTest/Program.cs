using DataCommon;

namespace ConsoleTest
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello, World!");
        //    DataCommon.Kisi k = new Kisi()
        //}
        static void Main(string[] args)
        {
            
            Kisi k1 = new Employee();
            k1.FirstName = "Ali";
            k1.LastName = "Diker";

            Kisi k2 = new Employee {FirstName="Ayşe",LastName="Kara"};
            Kisi k3 = new Customer {FirstName = "Ebru", LastName = "Demir" };
            //INotification k4.= new Customer {FirstName="aa",LastName="bb" };
            //k4.NotificationPreference  

            List<Kisi> list = new List<Kisi>();
            list.Add(k1);list.Add(k2);list.Add(k3); //Kisiye ekledik.
            
            foreach (var item in list)
            {
                Console.WriteLine(item.FullName);
            }


            //Product product = new Product();
            //product.Category = "Mobilya";
            //Console.WriteLine(product.Category);
        }
    }
    //class Product
    //{
    //    private int Id { get; set; }

    //        //private string Category { get; set; } // bunun yerine aşağıdaki gibi de yazabiliriz içerikle işlem yapabiliyoruz
    //    public string category;
    //    public String Category
    //    {
    //        get { return category; }
    //        set { category = value; }
    //    }

        
  

}