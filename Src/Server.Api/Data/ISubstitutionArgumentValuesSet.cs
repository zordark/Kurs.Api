using System.Collections.Generic;

namespace Kurs.Api.Server.Data
{
    /// <summary>
    ///  ласс описывает набор входных и соответствующих им выходных значений аргументов
    /// </summary>
    public interface ISubstitutionArgumentValuesSet
    {
        /// <summary>
        /// »дентификатор набора значений аргументов подстановки 
        /// </summary>
        int Id { get; }

        /// <summary>
        /// ѕор€док следовани€/номер строки (дл€ UI)
        /// </summary>
        int Order { get; }

        IEnumerable<ISubstitutionInputArgumentValue> InputValues { get; }

        IEnumerable<ISubstitutionOutputArgumentValue> OutputValues { get; }
    }
}