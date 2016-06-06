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
        /// Включает ручную установку значения аргумента. 
        /// Если false, то значение аргумента должно обязательно быть определено подстановкой)
        /// </summary>
        bool Enabled { get; }

        /// <summary>
        /// Реальное значение для аргумента команды
        /// </summary>
        string Value { get; }

        /// <summary>
        /// Отображаемое значение для аргумента команды
        /// </summary>
        string DisplayValue { get; }
    }
}