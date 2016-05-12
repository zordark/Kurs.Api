namespace Kurs.Api.Data
{
    /// <summary>
    /// Описание аргумента подстановки
    /// </summary>
    public class SubstitutionArgument
    {
        /// <summary>
        /// Идентификатор аргумента подстановки 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Описатель атрибута с которым связан аргумент подстановки
        /// </summary>
        public AttributeDescriptor Descriptor { get; set; }

        /// <summary>
        /// Порядок следования агрумента (видимо для UI)
        /// </summary>
        public int Order { get; set; }
    }
}