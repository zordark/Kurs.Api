using System;
using System.Collections.Generic;

namespace Kurs.Api.Server.Dto
{
    public class Substitution
    {
        /// <summary>
        /// »дентификатор подстановки 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Ќазвание подстановки
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// ѕризнак того, что подтсановка должна автоматически мапить входные аргументы в выходные, при этом
        /// необходимо только задать набор входных и выходных аргументов, количество входных и выходных аргументов должно совпадать,
        /// каждому входному аргументу будет соответствовать выходной аргумент согласно заданному пор€дку.
        /// ≈сли AutoMapping включен, то набор значени€ агрументов не задаетс€.
        /// </summary>
        public bool AutoMapping { get; set; }

        /// <summary>
        /// Ќабор входных аргументов подстановки 
        /// </summary>
        public IEnumerable<SubstitutionArgument> InputArguments { get; set; }

        /// <summary>
        /// Ќабор выходных аргументов подстановки
        /// </summary>
        public IEnumerable<SubstitutionArgument> OutputArguments { get; set; }

        /// <summary>
        /// Ќабор значений входных и соответствующий им набор значений выходных аргументов.
        /// «адаетс€ только в случае, если AutoMapping = false
        /// </summary>
        public IEnumerable<SubstitutionArgumentValuesSet> ArgumentValues { get; set; }


//        /// <summary>
//        /// Ќабор входных аргументов подстановки (AttributeDescriptorID)
//        /// </summary>
//        public IEnumerable<int> InputArguments { get; set; }
//
//        /// <summary>
//        /// Ќабор выходных аргументов подстановки (AttributeDescriptorID)
//        /// </summary>
//        public IEnumerable<int> OutputArguments { get; set; }
//
//        /// <summary>
//        /// Ќабор значений входных и соответствующий им набор значений выходных аргументов.
//        /// «адаетс€ только в случае, если AutoMapping = false
//        /// </summary>
//        public IEnumerable<Dictionary<int,string>> ArgumentValues { get; set; }
    }
}