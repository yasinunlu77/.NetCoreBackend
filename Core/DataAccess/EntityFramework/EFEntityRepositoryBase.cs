using Core.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    public class EFEntityRepositoryBase<Entity, Context> : IEntityRepository<Entity>
        where Entity : class, IEntity, new()
        where Context : DbContext, new()
    {
        public void Add(Entity entity)
        {
            using (Context context = new Context())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Entity entity)
        {
            using (Context context = new Context())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Entity Get(Expression<Func<Entity, bool>> filter)
        {
            using (Context context = new Context())
            {
                return context.Set<Entity>().SingleOrDefault(filter);
            }
        }

        public List<Entity> GetAll(Expression<Func<Entity, bool>> filter = null)
        {
            using (Context context = new Context())
            {
                return filter == null
                    ? context.Set<Entity>().ToList()
                    : context.Set<Entity>().Where(filter).ToList();
            }
        }

        public void Update(Entity entity)
        {
            using (Context context = new Context())
            {
                var UpdatedEntity = context.Entry(entity);
                UpdatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
