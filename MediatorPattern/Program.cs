using MediatorPattern.Colleague;
using MediatorPattern.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //list of participants
            IColleague<string> mark = new ConcreteColleague<string>("Mark");
            IColleague<string> cj = new ConcreteColleague<string>("CJ");
            IColleague<string> paul = new ConcreteColleague<string>("Paul");
            IColleague<string> geno = new ConcreteColleague<string>("Geno");
            IColleague<string> tessa = new ConcreteColleague<string>("Tessa");

            IColleague<int> account1 = new ConcreteColleague<int>("Kris Account");
            IColleague<int> account2 = new ConcreteColleague<int>("Joel Account");
            IColleague<int> account3 = new ConcreteColleague<int>("Ronald Account");

            Console.WriteLine("\n-- CHAT ROOM --");
            IMediator<string> chatRoom1 = new ConcreteMediator<string>();
            //participants registers to the mediator
            chatRoom1.Register(mark);
            chatRoom1.Register(cj);
            chatRoom1.Register(paul);
            chatRoom1.Register(tessa);
            //participantA sends out a message
            mark.SendMessage(chatRoom1, "message from MARK in chatroom 1!");

            Console.WriteLine("\n-- MONEY TRANSFER --");
            IMediator<int> PaymentGateway = new ConcreteMediator<int>();
            //participants registers to the mediator
            PaymentGateway.Register(account1);
            PaymentGateway.Register(account2);
            PaymentGateway.Register(account3);
            //participantB sends out a message
            account1.SendMessage(PaymentGateway, 999);

            Console.ReadKey();
        }
    }
}
