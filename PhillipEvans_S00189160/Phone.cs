using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhillipEvans_S00189160
{
    public class Phone
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string OperatingSystem { get; set; }
        public string OS_Image { get; set; }
        public string Phone_Image { get; set; }

        public Phone(string name, double price, string operatingSystem, string os_Image, string phone_Image)
        {
            this.Name = name;
            this.Price = price;
            this.OperatingSystem = operatingSystem;
            this.OS_Image = os_Image;
            this.Phone_Image = phone_Image;
        }

        public void IncreasePrice(double percent)
        {
            Price += (Price * percent);
        }

    }

    public class PhoneData : DbContext
    {

        public PhoneData() : base("MyPhoneData") { }
        public DbSet<Phone> Phones { get; set; }
    }
}
