namespace Kurs.Api.Server.Data
{
    /// <summary>
    /// Описание аргумента подстановки
    /// </summary>
    public interface ISubstitutionArgument
    {
        /// <summary>
        /// Идентификатор аргумента подстановки 
        /// </summary>
        int Id { get; }

        /// <summary>
        /// Описатель атрибута с которым связан аргумент подстановки
        /// </summary>
        IAttributeDescriptor Descriptor { get; }

        /// <summary>
        /// Порядок следования агрумента (для UI)
        /// </summary>
        int Order { get; }
    }
}