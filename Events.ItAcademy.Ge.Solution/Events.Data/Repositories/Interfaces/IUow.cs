using Events.Data.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Data.Repositories.Interfaces
{
    public interface IUow
    {
        #region Repos

        public IRepository<Event> Events { get; }

        #endregion Repos

        void SaveChanges();
        Task SaveChangesAsync();
        void Dispose();
    }
}
