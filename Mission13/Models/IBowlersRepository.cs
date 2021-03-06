using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission13.Models
{
    public interface IBowlersRepository
    {
        IQueryable<Bowler> Bowlers { get; }

        void SaveChanges(Bowler b);
        void AddBowler(Bowler b);
        void DeleteBowler(Bowler b);
    }
}
