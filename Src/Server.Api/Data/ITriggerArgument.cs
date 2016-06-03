namespace Kurs.Api.Server.Data
{
    /// <summary>
    /// Описание аргумента триггера
    /// </summary>
    public interface ITriggerArgument
    {
//        /// <summary>
//        /// Идентификатор аргумента триггера
//        /// </summary>
//        int Id { get; }

        /// <summary>
        /// Описатель атрибута события, с которым связан аргумент ториггера
        /// </summary>
        IAttributeDescriptor Descriptor { get; }

        /// <summary>
        /// Включает или отключает фильтр по этому аргументу
        /// </summary>
        bool Enabled { get; }

        /// <summary>
        /// Значение для сравнения со значением атрибута события, указанного в EventArgumentDescriptor
        /// </summary>
        string SimpleCompare { get; }

        /// <summary>
        /// Регулярное выражение для сравнения со значением атрибута события, указанного в EventArgumentDescriptor
        /// </summary>
        string RegexCompare { get; }
    }
}