using Kurs.Api.Server.Data;

namespace Kurs.Api.Server.Dto
{
    /// <summary>
    /// Описание аргумента триггера
    /// </summary>
    public class TriggerArgument
    {
        /// <summary>
        /// Идентификатор аргумента триггера
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Описатель атрибута события, с которым связан аргумент ториггера.
        /// <see cref="IAttributeDescriptor"/>
        /// </summary>
        public int DescriptorId { get; set; }

        /// <summary>
        /// Включает или отключает фильтр по этому аргументу
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// Значение для сравнения со значением атрибута события, указанного в EventArgumentDescriptor
        /// </summary>
        public string SimpleCompare { get; set; }

        /// <summary>
        /// Регулярное выражение для сравнения со значением атрибута события, указанного в EventArgumentDescriptor
        /// </summary>
        public string RegexCompare { get; set; }
    }
}