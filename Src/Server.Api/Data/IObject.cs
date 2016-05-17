namespace Kurs.Api.Server.Data
{
    /// <summary>
    /// Экземпляр мета-типа
    /// </summary>
    public interface IObject
    {
        int Id { get; }

        string Uid { get; }

        string DisplayName { get; }

        /// <summary>
        /// Какому адаптеру принадлежит объект
        /// </summary>
        IAdapter Adapter { get; }

        /// <summary>
        /// Родительский объект
        /// </summary>
        IObject Parent { get; }

//        /// <summary>
//        /// Дочерние объекты
//        /// </summary>
//        public virtual ICollection<Instance> Childs { get; set; }
    }
}