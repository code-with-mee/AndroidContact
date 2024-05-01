using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndroidContact
{
    public class App
    {
        private CContactEntities db = new CContactEntities();
        public void Run()
        {
            string vcardcontents = "";
            var users = db.users.Where(u => u.id <= 30000);
            int count = 0;
            foreach (user user in users)
            {
                count++;
                Contact contact = new Contact
                {
                    FirstName = user.name,
                    LastName = user.name,
                    Addresses = new List<Address>()
                    {
                        { new Address(){ Description="Cambodia", Type="Home"} },
                    },
                    Phones = new List<Phone>()
                    {
                        { new Phone(){ Number=user.phone, Type="Home"} }
                    },
                    Email = "someone"+count+"@bot-cambodia.com",
                    Organization = user.name,
                    Title = "Person" + count
                };

                vcardcontents += FileHelper.CreateVCard(contact);
                Console.WriteLine(count);
            }

            string SavePath = Path.Combine(AppContext.BaseDirectory, "contact.vcf");
            File.WriteAllText(SavePath, vcardcontents);
            Console.WriteLine("File saved at " + SavePath.Trim());
        }
    }
}
