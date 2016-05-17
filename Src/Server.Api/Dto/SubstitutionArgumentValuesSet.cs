using System.Collections.Generic;

namespace Kurs.Api.Server.Dto
{
    /// <summary>
    /// Класс описывает набор входных и соответствующих им выходных значений аргументов
    /// </summary>
    public class SubstitutionArgumentValuesSet
    {
        public int Id { get; set; }

        /// <summary>
        /// Порядок следования (для UI)
        /// </summary>
        public int Order { get; set; }

        public IEnumerable<SubstitutionArgumentValue> InputValues { get; set; }
    }
}