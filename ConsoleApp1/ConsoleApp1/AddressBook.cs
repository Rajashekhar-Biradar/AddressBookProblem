using System;
using AddressBook;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class AddressBook
    {

        public List<Contacts> personDetails = new List<Contacts>();
        public void AddPerson()
        {
            Contacts person = new Contacts();
            Console.WriteLine("Enter first name");
            person.firstName = Console.ReadLine();
            Console.WriteLine("Enter last name");
            person.lastName = Console.ReadLine();
            Console.WriteLine("Enter address name");
            person.address = Console.ReadLine();
            Console.WriteLine("Enter city name");
            person.city = Console.ReadLine();
            Console.WriteLine("Enter state name");
            person.state = Console.ReadLine();
            Console.WriteLine("Enter zip name");
            person.zip = Console.ReadLine();
            Console.WriteLine("Enter phone number");
            person.phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter email id");
            person.email = Console.ReadLine();
            personDetails.Add(person);
        }
    }
}