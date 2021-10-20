using Events.Data.Context;
using Events.Data.Models.Entities;
using Events.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Data.Repositories.Implementations
{
    public class Uow : IUow
    {
        private readonly EventsContext _context;

        public Uow(EventsContext context)
        {
            _context = context;
        }

        public IRepository<Event> Events
        {
            get
            {
                return new Repository<Event>(_context);
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
