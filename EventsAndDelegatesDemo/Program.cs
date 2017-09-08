using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Testing Events and Delegates.
//By Khai Wah Cheung. 08.09.2017.

namespace EventsAndDelegatesDemo
{
    public class Person
    {
        string name;

        public string Name{
            get => name;
            set => name = value;
        }

        public void changeName(string n)
        {
            string oldName = name;
            this.name = n;
            Console.WriteLine("@Person: Name changed from {0} to {1}", oldName, n);

            //raising the event
            OnNameChanged();
        }

        //Built-in delegate
        public event EventHandler NameChanged;

        protected virtual void OnNameChanged()
        {
            //checking if there are any subscribers
            if (NameChanged != null) 
            {
                NameChanged(this, EventArgs.Empty);
            }
        }

    }

    class Goverment {
        public void OnNameChanged(object source, EventArgs e)
        {
            Console.WriteLine("@Goverment: Received name change event.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person() { Name = "Khai Wah Cheung" };
            var goverment = new Goverment();

            //subscription
            person.NameChanged += goverment.OnNameChanged;

            person.changeName("John Petrucci");
        }
    }
}
