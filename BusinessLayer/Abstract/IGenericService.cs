namespace BusinessLayer.Abstract
{
    // Generic metotlar haricinde bir entitye özel metot lazımsa kendi abstractını yazarız
    public interface IGenericService<T>
    {
        void TAdd(T entity);
        void TDelete(T entity);
        void TUpdate(T entity);
        List<T> TGetList();
        T TGetById(int id);
    }
}
