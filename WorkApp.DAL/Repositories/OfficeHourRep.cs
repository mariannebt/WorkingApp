using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using WorkApp.Entity;
using WorkApp.DAL.Context;

namespace WorkApp.DAL.Repositories
{
    public class OfficeHourRep : GenericRepository<OfficeHour>
    {
        public virtual List<OfficeHour> FindComplete()
        {
            using (DataContext d = new DataContext())
            {
                return d.OfficeHour                //Select in Activity
                        .Include(o => o.Employee)// Join
                        .ToList();
            }
        }
        public virtual List<OfficeHour> FindByStart(DateTime start)
        {
            using (DataContext d = new DataContext())
            {
                return d.OfficeHour                //Select in Activity
                        .Include(o => o.Employee) // Join
                        .Where(o => o.StartDate  == start)
                        .ToList();
            }
        }
        public virtual List<OfficeHour> FindByEnd(DateTime end)
        {
            using (DataContext d = new DataContext())
            {
                return d.OfficeHour                //Select in Activity
                        .Include(o => o.Employee) // Join
                        .Where(o => o.EndDate == end)
                        .ToList();
            }
        }
        public virtual List<OfficeHour> FindByDate(DateTime start, DateTime end)
        {
            using (DataContext d = new DataContext())
            {
                return d.OfficeHour                //Select in Activity
                        .Include(o => o.Employee) // Join
                        .Where(o => o.StartDate == start && o.EndDate == end)
                        .ToList();
            }
        }
    }
}
