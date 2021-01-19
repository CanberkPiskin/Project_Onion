using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.Management.IntManager
{
    public interface IManager<T> where T:BaseEntity
    {
        List<T> GetActives();
        List<T> GetPassives();
        List<T> GetModifieds();
        List<T> GetAll();

        void Add(T item);
        void Delete(T item);
        void Destroy(T item);
        void Update(T item);
        void AddRange(List<T> item);
        void DeleteRange(List<T> item);
        void DestroyRange(List<T> item);
        void UpdateRange(List<T> item);

        List<T> Where(Expression<Func<T, bool>> exp);
        bool Any(Expression<Func<T, bool>> exp);
        T FirstOrDefault(Expression<Func<T, bool>> exp);
        object Select(Expression<Func<T, object>> exp);

        T Find(int id);
    }
}
