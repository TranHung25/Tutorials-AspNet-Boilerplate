using Acme.SimpleTaskApp.EntityFrameworkCore;
using Acme.SimpleTaskApp.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.SimpleTaskApp.Tests
{
        public class TestDataBuilder
        {
            
            private readonly SimpleTaskAppDbContext _context;

            public TestDataBuilder(SimpleTaskAppDbContext context)
            {
                _context = context;
            }

            public void Build()
            {


                var neo = new Person("Neo");
                _context.People.Add(neo);
                _context.SaveChanges();

                _context.Tasks.AddRange(
                    new SimpleTaskApp.Tasks.Task("Follow the white rabbit", "Follow the white rabbit in order to know the reality.", neo.Id),
                    new SimpleTaskApp.Tasks.Task("Clean your room") { State = TaskState.Completed }
                    );
            }
        }
    
}
