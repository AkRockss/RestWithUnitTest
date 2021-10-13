using RestWithUnitTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithUnitTest.Managers
{
    public class ByciclesManager
    {

        private static int _nextId = 1;

        private static readonly List<Bycicles> Blist = new List<Bycicles>
        {
            new Bycicles {Id = _nextId++, Name = "Raleigh", Price = 6000},
            new Bycicles {Id = _nextId++ , Name = "Nishiki", Price = 12000}
        };

        public List<Bycicles> GetAll()
        {
            return new List<Bycicles>(Blist);

        }

        public Bycicles GetById(int id)
        {
            return Blist.Find(Item => Item.Id == id);
        }


        public Bycicles Add(Bycicles newBycicles)
        {
            newBycicles.Id = _nextId++;
            Blist.Add(newBycicles);
            return newBycicles;
        }

        public Bycicles Delete(int id)
        {
            Bycicles bycicles = Blist.Find(Bycicles1 => Bycicles1.Id == id);
            if (bycicles == null) return null;
            Blist.Remove(bycicles);
            return bycicles;
        }

        public Bycicles Update(int id, Bycicles updates)
        {
            Bycicles bycicles = Blist.Find(bycicles1 => bycicles1.Id == id);
            if (bycicles == null) return null;
            bycicles.Name = updates.Name;
            bycicles.Price = updates.Price;
            return bycicles;
        }




    }
}
