using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Person
    {
        public string Name { get; set; }

        public BlessYouDelegate BlessYouWishes;

        public void SayBlessYou(Person sender, PrshtaluEventArgs args)
        {
            string zarmanq = "";
            if (args.Level >= 51)
            {
                zarmanq = "Vay qu ara! ";
            }
            if (sender.Name != "Mukuch")
            {
                Console.WriteLine($"{Name} says bless you to {sender.Name}  at {DateTime.Now}. {zarmanq}");
            }
            else
            {
                Console.WriteLine($"{Name} says mernem janin to {sender.Name}  at {DateTime.Now}. {zarmanq}");
            }
        }

        public void Prshtal()
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            int level = rand.Next(30, 100);
            Console.WriteLine($"{Name} did a prtshotc. at {DateTime.Now} Level {level}");
            BlessYouWishes(this, new PrshtaluEventArgs() {
                Level = level
            });
        }
    }
}
