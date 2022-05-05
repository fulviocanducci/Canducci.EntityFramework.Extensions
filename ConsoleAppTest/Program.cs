using System;
using DataAccess;
using Canducci.EntityFramework.Extensions;
using System.Linq;

namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            using DatabaseContext db = new();
            db.LoadPeople();
            bool? active = null;
            DateTime? updateAt = null;
            int line = 0;
            db.People
                .OrderBy(x => x.Active)                
                .Take(1)
                .When(updateAt, x => x.UpdateAt == updateAt)
                .When(active, x => x.Active == active)
                .ToList()
                .ForEach(item =>
                {
                    Console.WriteLine("{0:00} {1} {2} {3} {4} {5}", ++line, item.Id, item.Name, item.CreatedAt, item.UpdateAt, item.Active);
                });            
        }
    }
}
