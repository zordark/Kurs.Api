using System;

namespace Kurs.Api.Server.Data
{
    /// <summary>
    /// Аргумент реакции
    /// </summary>
    public interface ITriggerActionArgument
    {
//        /// <summary>
//        /// идентификатор аргумента реакции
//        /// </summary>
//        int Id { get; }

        /// <summary>
        /// Описатель аргумента команды
        /// </summary>
        IAttributeDescriptor Descriptor { get; }

        /// <summary>
        /// Значение для аргумента команды
        /// Если значение null, то значение соответствующего аргумента должно обязательно быть определено подстановкой
        /// </summary>
        string Value { get; set; }
    }
}