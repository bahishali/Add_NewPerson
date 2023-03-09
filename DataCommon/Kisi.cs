namespace DataCommon
{
    public abstract class Kisi
    {
        //public Kisi() { } //boş constructor
        //public Kisi(string firstname, string lastname)
        //{
        //    FirstName = firstname;
        //    LastName = lastname;
        //    constructor tanımladığımız zaman bunları girmemiz gerekiyor
        //    tanımlamamız şart değil
        //    boş constructor koyarsak girmek zorunda ollduğumuz yer olmaz
        //}
        //Nullabilty
        //int? id;


        //dışardan değer ataması yaptığımda sağında solundaki boşlukları trimlicek Büyük yaz 
        //    string lastName;
        //    public String LastName { get => lastName; set => firstNa = value.Trim().ToUpper();
        //}


        //public string firstname;
        public String FirstName { get; set; }

        string lastname;
        public String LastName
        { 
            get { return lastname; }
            set { lastname = value.Trim().ToUpper(); } 
        }

        public String FullName
        {
            get
            {
                //return FirstName + " " + LastName; } } //sadece get , set yok dışardan getirsin istemiyorum
                return String.Format("{0} {1}", FirstName, LastName);//çok uzun stringlerin arasından seçmek için kolaylaştırıyo"" dan sonrakileri indexliyor
                //return String.Format("{1}, {0}", FirstName, LastName);//önce soyadı sonra adı yazacaktı
            }
        }
    }
}