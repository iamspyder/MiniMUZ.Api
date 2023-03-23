namespace MiniMUZ.Api.MuzModels.Repository
{
    public interface IMuz<T, TDTO> where T : class
    {
        T GetById(int id);
        IEnumerable<T> GetAll();

        T Get(long id);
        TDTO GetDto(long id);
        void Add(T entity);

        void Adds(TDTO entity);
        void Update(T entity);
        void Delete(T entity);
        void DeleteById(int id);
    }
}
