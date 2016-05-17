using Kurs.Api.Server.Data;

namespace Kurs.Api.Server.Dto
{
    /// <summary>
    /// Аргумент реакции
    /// </summary>
    public class TriggerActionArgument
    {
        /// <summary>
        /// идентификатор аргумента реакции
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Описатель аргумента команды.
        /// <see cref="IAttributeDescriptor"/>
        /// </summary>
        public int DescriptorId { get; set; }

        /// <summary>
        /// Значение для аргумента команды
        /// Если значение null, то значение соответствующего аргумента должно обязательно быть определено подстановкой
        /// </summary>
        public string Value { get; set; }
    }
}