using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp.Depo
{
    public interface IDepo<TEntity>
    {
        void Insert(TEntity entity);
        void Add(TEntity entity);
        void Delete(int entityId);
        void Update(TEntity entity);
    }
}
