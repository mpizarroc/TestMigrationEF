using Microsoft.EntityFrameworkCore;
using System;

namespace TestMigrationEF
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppContext())
            {
                context.Database.Migrate();
                Console.WriteLine("Database has been migrated");
            }
        }
    }
}
