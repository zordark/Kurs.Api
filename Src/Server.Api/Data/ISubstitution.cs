using System.Collections.Generic;

namespace Kurs.Api.Server.Data
{
    /// <summary>
    /// Подстановка. Используется для формирования аргументов команды адаптера при сработке триггера
    /// </summary>
    public interface ISubstitution
    {
        /// <summary>
        /// Идентификатор подстановки 
        /// </summary>
        int Id { get; }

        /// <summary>
        /// Имя подстановки
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Признак того, что подтсановка должна автоматически мапить входные аргументы в выходные, при этом
        /// необходимо только задать набор входных и выходных аргументов, и каждому выходному аргументу сопоставить входной.
        /// В таких подстановках значения агрументов не могут быть указаны.
        /// </summary>
        bool AutoMapping { get; }

        /// <summary>
        /// Набор входных аргументов подстановки 
        /// </summary>
        IEnumerable<ISubstitutionArgument> InputArguments { get; }

        /// <summary>
        /// Набор выходных аргументов подстановки
        /// </summary>
        IEnumerable<ISubstitutionArgument> OutputArguments { get; }

        /// <summary>
        /// Набор значений входных и соответствующий им набор значений выходных аргументов
        /// </summary>
        IEnumerable<ISubstitutionArgumentValuesSet> ArgumentValues { get; }
    }
}