
using System;
namespace WilkersonRoboDialerV3
{
    class Phone
    {
        protected string phoneNumber;
        protected string companyName;
        protected string phoneType;



        public Phone(string phoneNumber, string companyName, string phoneType)
        {
            this.phoneNumber = phoneNumber;
            this.companyName = companyName;
            this.phoneType = phoneType;
        }



        public virtual string Dial()
        {
            return $"Dialing {companyName} using {phoneNumber}...";
        }
    }



    class HomePhone : Phone
    {
        public HomePhone(string phoneNumber, string companyName, string phoneType)
        : base(phoneNumber, companyName, phoneType)
        {
        }
    }



    class CellPhone : Phone
    {
        public CellPhone(string phoneNumber, string companyName, string phoneType)
        : base(phoneNumber, companyName, phoneType)
        {
        }



        public override string Dial()
        {
            string prefix = "1+";
            string formattedPhoneNumber = phoneNumber.Replace("(", "").Replace(")", "").Replace(" ", "");
            return $"Dialing {companyName} using {prefix}{formattedPhoneNumber}...";
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Phone[] dialingList = new Phone[10];



            dialingList[0] = new CellPhone("(800) 969-4374", "ErgoSource", "1");
            dialingList[1] = new CellPhone("(800) 874-8527", "Fox Bay Industries", "2");
            dialingList[2] = new HomePhone("(303) 985-5060", "CompuTest", "1");
            dialingList[3] = new HomePhone("(603) 532-4123", "Curtis Manufacturing", "2");
            dialingList[4] = new CellPhone("(800) 876-2524", "Data Functions", "1");
            dialingList[5] = new CellPhone("(708) 397-3330", "Donnay Repair", "1");
            dialingList[6] = new CellPhone("(360) 434-3894", "ErgoNomic Inc", "1");
            dialingList[7] = new CellPhone("(800) 545-6254", "Glare-Guard", "2");
            dialingList[8] = new CellPhone("(407) 783-6641", "Hazard Comm Specialists", "2");
            dialingList[9] = new CellPhone("(714) 472-4409", "Komfort Support", "2");



            foreach (Phone phone in dialingList)
            {
                Console.WriteLine(phone.Dial());
            }
        }
    }
}

