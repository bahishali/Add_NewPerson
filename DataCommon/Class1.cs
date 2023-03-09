using DataCommon;

namespace DataCommon
{
    public enum NotificationType
    {
        sms,
        email
    }
    public interface INotification
    {
        NotificationType NotificationPreference { get; }

     //   public object Clone();
    }


    public class Customer : Kisi, INotification //ICloneable
    {

        public List<Address> Addresses { get; set; } // müşterinin 1den fazla adresi olabilir sınırsız hale geldi, arraylist de yapabiliriz
        public NotificationType NotificationPreference
        { get { return NotificationType.email; } }

        //public object Clone()
        //{
        //    throw new NotImplementedException();
        //}
    }
    //public object Clone()
    //{
    ////    throw new NotImplementedException();
    //}
    //public object Clone()
    //{
    //    Customer m = new Customer();
    //    m.FirstName = this.FirstName; //bi tane Firstname oldg için this yazmamıza gerek yoktu
    //    m.LastName = this.LastName;   //bi tane Lastname oldg için this yazmamıza gerek yoktu
    //}

    public class Employee : Kisi
    {
        public String RegisNo { get; set; }

        public int Departmant { get; set; } //bölümler int ile test edilir

        public Address HomeAddress { get; set; }

    }
    public class SMS { }
    public class Email { }
    
    //public class Product
    //{

    //    private int Id { get; set; }

    //    //private string Category { get; set; } // bunun yerine aşağıdaki gibi de yazabiliriz içerikle işlem yapabiliyoruz
        
    //    public string category;
    //    public String Category
    //    {
    //        get { return category; }
    //        set { category = value; }
    //    }
        
    //}
}
