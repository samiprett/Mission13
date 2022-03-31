using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission13.Models
{
    public class EFBowlersRepository : IBowlersRepository 
    {
        private BowlingDbContext _context { get; set; }
        public EFBowlersRepository (BowlingDbContext temp)
        {
            _context = temp;
        }
        public IQueryable<Bowler> Bowlers => _context.Bowlers;

        public void SaveChanges(Bowler b)
        {
            _context.Update(b);
            _context.SaveChanges();
        }

        public void AddBowler(Bowler b)
        {
            Bowler bowler = new Bowler();
            _context.Add(b);
            _context.SaveChanges();
        }

        public void DeleteBowler(Bowler b)
        {
            _context.Bowlers.Remove(b);
            _context.SaveChanges();
        }
    }
}
