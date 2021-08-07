using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace AdvancoTask
{
    public class PersonelDal
    {
        public List<Personel> GetAll(Expression<Func<Personel, bool>> filter = null)
        {
            using (AdvancoContext context = new AdvancoContext())
            {
                return filter == null ?
                    context.Set<Personel>().ToList() :
                    context.Set<Personel>().Where(filter).ToList();
            }
        }
        public void Add(Personel personal)
        {
            try
            {
                using (AdvancoContext context = new AdvancoContext())
                {
                    var entity = context.Entry(personal);
                    entity.State = EntityState.Added;
                    context.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Update(Personel personal)
        {
            using (AdvancoContext context = new AdvancoContext())
            {
                var entity = context.Entry(personal);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Delete(Personel personal)
        {
            using (AdvancoContext context = new AdvancoContext())
            {
                var entity = context.Entry(personal);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
