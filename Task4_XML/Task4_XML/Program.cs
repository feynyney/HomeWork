using System;
using System.Xml.Linq;

namespace Task4_XML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XElement myPERSON = new XElement("Person");
            XElement myADRESS = new XElement("Adress");
            XElement mySTREET = new XElement("Street");
            XElement myFLATNUM = new XElement("FlatNumber");
            XElement myHOUSENUM = new XElement("HouseNumber");
            XElement myPHONES = new XElement("Phones");
            XElement myMOBILEPHONE = new XElement("MobilePhone");
            XElement myFLATPHONE = new XElement("FlatPhone");

            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your street: ");
            string street = Console.ReadLine();

            Console.WriteLine("Enter your house number: ");
            string house_num = Console.ReadLine();

            Console.WriteLine("Enter your flat number: ");
            string flat_num = Console.ReadLine();

            Console.WriteLine("Enter your phone number: ");
            string phone_num = Console.ReadLine();

            Console.WriteLine("Enter your flat phone: ");
            string flat_phone = Console.ReadLine();

            XAttribute xAttributeMyName = new XAttribute("name",name); 

            myPERSON.Add(xAttributeMyName);
            myPERSON.Add(myADRESS);
            mySTREET.Add(street);
            myHOUSENUM.Add(house_num);
            myFLATNUM.Add(flat_num);
            myMOBILEPHONE.Add(phone_num);
            myFLATPHONE.Add(flat_phone);
            myADRESS.Add(mySTREET, myHOUSENUM, myFLATNUM);  
            myPHONES.Add(myMOBILEPHONE, myFLATPHONE);
            myPERSON.Add(myPHONES);

            myPERSON.Save("Name.xml"); //save
        }
    }
}
