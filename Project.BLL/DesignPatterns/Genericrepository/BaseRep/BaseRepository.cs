using Project.BLL.DesignPatterns.Genericrepository.IntRep;
using Project.BLL.DesignPatterns.SingletonPattern;
using Project.DAL.Context;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.Genericrepository.BaseRep
{
    public abstract class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        MyContext _db;

        public BaseRepository()
        {
            _db = DBTool.DBInstance;
        }


        
        public void Add(T item)
        {

            // T neyse ona göre şekilleneceksin ve ekleme  yapacaksın
            _db.Set<T>().Add(item);// Veri tabanına git kendini T ye göre set et onun ekleme metodunu çalıştır.
            Save();
        }

        private void Save()
        {
            _db.SaveChanges();
        }

        public bool Any(Expression<Func<T, bool>> exp)
        {
            return _db.Set<T>().Any(exp);
        }

        public void Delete(T item)
        {
            item.DeletedDate = DateTime.Now;
            item.Status = ENTITIES.Enums.DataStatus.Deleted;
            Save();
        }

        public void Destroy(T item)
        {
            _db.Set<T>().Remove(item);//ya set et ya terket :)
            Save();
        }

        public T Find(int id)
        {
            return _db.Set<T>().Find(id);
        }       

        public T FirstOrDefault(Expression<Func<T, bool>> exp)
        {
            return _db.Set<T>().FirstOrDefault(exp);
        }

        public List<T> GetActives()
        {
            return Where(x => x.Status != ENTITIES.Enums.DataStatus.Deleted);
        }

        public List<T> GetAll()
        {
            return _db.Set<T>().ToList();
        }

        public List<T> GetModifieds()
        {
            return Where(x => x.Status == ENTITIES.Enums.DataStatus.Updated);
        }

        public List<T> GetPassive()
        {
            return Where(x => x.Status == ENTITIES.Enums.DataStatus.Deleted);
        }

        public object Select(Expression<Func<T, object>> exp)
        {
            return _db.Set<T>().Select(exp).ToList();
        }

        public void Update(T item)
        {
            item.ModifiedDate = DateTime.Now;
            item.Status = ENTITIES.Enums.DataStatus.Updated;
            T toBeUpdated = Find(item.ID);
            //bize gelen item in ID sini bularak toBeUpdated attık
            //Entry demek database bir güncelleme işlemi yapacak demektir.
            _db.Entry(toBeUpdated).CurrentValues.SetValues(item);//currentvalues eski verinin bilgisi onu set edip id den bularak set ediyoruz.
            Save();//set bir veri tabanının içindeki tablonun neye göre bulunacağını belirler.T neyse verdiğim tipe göre bul demektir.
        }

        public List<T> Where(Expression<Func<T, bool>> exp)
        {
            //kendi where tasarlıyoruz
            return _db.Set<T>().Where(exp).ToList();
        }
    }
}
