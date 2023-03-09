using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCommon
{
    public enum AddressType
    {
        home=1, //sadece ev adreslerine bir şey göndermek istediğim zaman filtreleme açısından pratiklik sağlıyor
        business=2
    }
    //mmüşteri ve çalışan için ayrı ayrı tanımlamak yerine farklı yerlerden çağırabilir olması için açtık tekrar tekrar çağırılmasa bile ayrı bir yerde tanımlamamız iyi olur

    public class Address
    {
        //const int homeAddress = 1;
        //const int businessAddress = 2;

        public AddressType Type { get; set; }
        public string Title { get; set; }
        public string Row1 { get; set; }
        public string Row2 { get; set; }
        public int City { get; set; }
    }
}
