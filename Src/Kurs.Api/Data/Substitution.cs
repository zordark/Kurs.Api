using System.Collections.Generic;

namespace Kurs.Api.Data
{
    /// <summary>
    ///  ласс описывает подстановку
    /// </summary>
    public class Substitution
    {
        public int Id { get; set; }

        /// <summary>
        /// Ќазвание подстановки
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// ѕризнак того, что подтсановка должна автоматически мапить входные аргументы в выходные, при этом
        /// необходимо только задать набор входных и выходных аргументов, и каждому выходному аргументу сопоставить входной.
        /// ¬ таких подстановках значени€ агрументов не могут быть указаны.
        /// </summary>
        public bool AutoMapping { get; set; }

        /// <summary>
        /// Ќабор входных аргументов подстановки 
        /// </summary>
        public IEnumerable<SubstitutionInputArgument> InputArguments { get; set; }

        /// <summary>
        /// Ќабор выходных аргументов подстановки
        /// </summary>
        public IEnumerable<SubstitutionOutputArgument> OutputArguments { get; set; }

        /// <summary>
        /// Ќабор значений входных и соответствующий им набор значений выходных аргументов
        /// </summary>
        public IEnumerable<SubstitutionArgumentValuesSet> ArgumentValues { get; set; }
    }
}