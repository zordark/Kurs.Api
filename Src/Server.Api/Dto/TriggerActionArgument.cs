using Kurs.Api.Server.Data;

namespace Kurs.Api.Server.Dto
{
    /// <summary>
    /// Аргумент реакции
    /// </summary>
    public class TriggerActionArgument
    {
        /// <summary>
        /// Описатель аргумента команды.
        /// <see cref="IAttributeDescriptor"/>
        /// </summary>
        public int DescriptorId { get; set; }

        /// <summary>
        /// Включает ручную установку значения аргумента. 
        /// Если false, то значение аргумента должно обязательно быть определено подстановкой)
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// Значение для аргумента команды
        /// </summary>
        public string Value { get; set; }
    }
}