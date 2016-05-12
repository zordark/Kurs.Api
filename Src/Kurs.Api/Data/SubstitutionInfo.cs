namespace Kurs.Api.Data
{
    /// <summary>
    /// Класс описывает подстановку для представления в табличном виде
    /// </summary>
    public class SubstitutionInfo
    {
        /// <summary>
        /// Идентификатор подстановки
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Название подстановки
        /// </summary>
        public string Name { get; set; }
    }
}