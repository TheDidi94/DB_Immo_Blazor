using Immobilien.Data;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Immobilien.Services
{
    public class HouseService
    {
        private readonly ApplicationDbContext _db;

        public HouseService(ApplicationDbContext db)
        {
            _db = db;
        }

        public House GetHouse(int id)
        {
            House obj = new House();
            return _db.Houses.FirstOrDefault(u => u.ID == id);
        }

        public List<House> GetHouses(bool kauf)
        {
            //Gibt nur Häuser vom Typ 'Kauf' oder vom Typ 'Miete' zurück.
            return _db.Houses.Where(u => u.Kauf == kauf).ToList(); ;
        }

        public bool CreateHouse(House objHouse)
        {
            try
            {
                _db.Houses.Add(objHouse);
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                //ToDo: Error Handling

                return false;
            }
            return true;
        }

        public bool UpdateHouse(House objHouse)
        {
            var existingHouse = _db.Houses.FirstOrDefault(u => u.ID == objHouse.ID);
            if (existingHouse != null)
            {
                try
                {
                    _db.Houses.Update(objHouse);
                    _db.SaveChanges();
                }
                catch (Exception e)
                {
                    //ToDo: Error Handling
                    return false;
                }
            }
            else
            {
                return false;
            }
            return true;
        }

        public bool DeleteHouse(House objHouse)
        {
            var existingHouse = _db.Houses.FirstOrDefault(u => u.ID == objHouse.ID);
            if (existingHouse != null)
            {
                _db.Houses.Remove(objHouse);
                _db.SaveChanges();
            }
            else
            {
                return false;
            }
            return true;
        }
    }
}
