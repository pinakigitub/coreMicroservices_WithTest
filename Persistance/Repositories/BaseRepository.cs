using Persistance.EF;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistance.Repositories
{
    public abstract class BaseRepository
    {
        protected readonly kwooncjpContext _context;

        public BaseRepository(kwooncjpContext context)
        {
            _context = context;
        }
    }
}
