using Adres_Defteri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adres_Defteri
{
    public class User
    {
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public string HomePhone { get; set; }
        public virtual void userInformation () {
            Console.WriteLine($"Kullanicinin ismi {UserName}");
            Console.WriteLine($"Kullanicinin cep numarasi {PhoneNumber}");
            Console.WriteLine($"Kullanicinin ev telefonu {HomePhone}");
        }
    }
}
public class AdressInfo : User
{
    public string City;
    public string Country;
    public int ApartmentNo;
    public string StreetName;
    public string District;

    public override void userInformation ()
    {
        Console.WriteLine($"Kullanicinin ismi {UserName}");
        Console.WriteLine($"Kullanicinin cep numarasi {PhoneNumber}");
        Console.WriteLine($"Kullanicinin ev telefonu {HomePhone}");
        Console.WriteLine($"Adres: {City} No: {ApartmentNo}, {Country}, {District}, {StreetName}");
    }
}
