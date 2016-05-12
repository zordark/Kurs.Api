using System.Collections.Generic;

namespace Kurs.Api.Data
{
    /// <summary>
    /// Класс описывает набор входных и соответствующих им выходных значений аргументов
    /// </summary>
    public class SubstitutionArgumentValuesSet
    {
        public int Id { get; set; }

        public int Order { get; set; }

        public IEnumerable<SubstitutionInputArgumentValue> InputValues { get; set; }

        public IEnumerable<SubstitutionOutputArgumentValue> OutputValues { get; set; }

    }
}