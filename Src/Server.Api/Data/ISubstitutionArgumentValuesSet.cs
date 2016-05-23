using System.Collections.Generic;

namespace Kurs.Api.Server.Data
{
    /// <summary>
    /// Класс описывает набор входных и соответствующих им выходных значений аргументов
    /// </summary>
    public interface ISubstitutionArgumentValuesSet
    {
        /// <summary>
        /// Идентификатор набора значений аргументов подстановки 
        /// </summary>
        int Id { get; }

        /// <summary>
        /// Порядок следования/номер строки (для UI)
        /// </summary>
        int Order { get; }

        /// <summary>
        /// Значения входных аргументов
        /// </summary>
        IEnumerable<ISubstitutionArgumentValue> InputValues { get; }

        /// <summary>
        /// Значения выходных аргументов
        /// </summary>
        IEnumerable<ISubstitutionArgumentValue> OutputValues { get; }
    }
}