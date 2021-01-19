using Project.BLL.Management.IntManager;
using Project.DAL.DesignPatterns.GenericRepository.EFRepository.BaseRep;//Burada sadece namespace değişikliği yaparak EFRepository,ADORepository veya MobilRepository ile çalışabilme imkanına sahibiz.
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.Management.BaseManager
{
    public abstract class BaseManager<T> : IManager<T> where T : BaseEntity
    {
        BaseRepository<T> _baseRep;

        public BaseManager()
        {
            _baseRep = new Project.DAL.DesignPatterns.GenericRepository.EFRepository.BaseRep.BaseRepository<T>();
            
        }

        public void Add(T item)
        {
            _baseRep.Add(item);
        }

        public void AddRange(List<T> item)
        {
            _baseRep.AddRange(item);
        }

        public bool Any(Expression<Func<T, bool>> exp)
        {
            return _baseRep.Any(exp);
        }

        public void Delete(T item)
        {
            _baseRep.Delete(item);
        }

        public void DeleteRange(List<T> item)
        {
            _baseRep.DeleteRange(item);
        }

        public void Destroy(T item)
        {
            _baseRep.Destroy(item);
        }

        public void DestroyRange(List<T> item)
        {
            _baseRep.DestroyRange(item);
        }

        public T Find(int id)
        {
            return _baseRep.Find(id);
        }

        public T FirstOrDefault(Expression<Func<T, bool>> exp)
        {
            return _baseRep.FirstOrDefault(exp);
        }

        public List<T> GetActives()
        {
            return _baseRep.GetActives();
        }

        public List<T> GetAll()
        {
            return _baseRep.GetAll();
        }

        public List<T> GetModifieds()
        {
            return _baseRep.GetModifieds();
        }

        public List<T> GetPassives()
        {
            return _baseRep.GetPassives();
        }

        public object Select(Expression<Func<T, object>> exp)
        {
            return _baseRep.Select(exp);
        }

        public void Update(T item)
        {
            _baseRep.Update(item);
        }

        public void UpdateRange(List<T> item)
        {
            _baseRep.UpdateRange(item);
        }

        public List<T> Where(Expression<Func<T, bool>> exp)
        {
            return _baseRep.Where(exp);
        }
    }
}
