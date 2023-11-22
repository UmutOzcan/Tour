using System.Linq.Expressions;

namespace DataAccessLayer.Abstract
{
    // Generic tanımlama ile entityleri parametre verdik
    public interface IGenericDal<T>
    {
        void Insert(T entity);
        void Delete(T entity);
        void Update(T entity);
        List<T> GetList();

        // sonradan destination için tanımladık
        T GetByID(int id);

        // arama işlemi icin
        List<T> GetListByFilter(Expression<Func<T, bool>> filter);
    }
}
