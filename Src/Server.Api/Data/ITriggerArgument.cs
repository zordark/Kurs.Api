namespace Kurs.Api.Server.Data
{
    /// <summary>
    /// Описание аргумента триггера
    /// </summary>
    public interface ITriggerArgument
    {
        /// <summary>
        /// Идентификатор аргумента триггера
        /// </summary>
        int Id { get; }

        /// <summary>
        /// Описатель атрибута события, с которым связан аргумент ториггера
        /// </summary>
        IAttributeDescriptor Descriptor { get; }

        /// <summary>
        /// Значение для сравнения со значением атрибута события, указанного в EventArgumentDescriptor
        /// </summary>
        string SimpleCompare { get; set; }

        /// <summary>
        /// Регулярное выражение для сравнения со значением атрибута события, указанного в EventArgumentDescriptor
        /// </summary>
        string RegexCompare { get; set; }
    }
}