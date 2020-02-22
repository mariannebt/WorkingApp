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
    public class ActivityRep : GenericRepository<Activity>
    {
        public virtual List<Activity> FindComplete()
        {
            using (DataContext d = new DataContext())
            {
                return d.Activity                //Select in Activity
                        .Include(a => a.Agenda) // Join
                        .ToList();
            }
        }

        public virtual List<Activity> FindByStart(DateTime start)
        {
            using (DataContext d = new DataContext())
            {
                return d.Activity                //Select in Activity
                        .Include(a => a.Agenda) // Join
                        .Where(a => a.Start == start)
                        .ToList();
            }
        }
        public virtual List<Activity> FindByEnd(DateTime end)
        {
            using (DataContext d = new DataContext())
            {
                return d.Activity                //Select in Activity
                        .Include(a => a.Agenda) // Join
                        .Where(a => a.End == end)
                        .ToList();
            }
        }
        public virtual List<Activity> FindByDate(DateTime start, DateTime end)
        {
            using (DataContext d = new DataContext())
            {
                return d.Activity                //Select in Activity
                        .Include(a => a.Agenda) // Join
                        .Where(a => a.Start == start && a.End == end)
                        .ToList();
            }
        }
    }
}
