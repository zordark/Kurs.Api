using System;

namespace Kurs.Api.Server.Dto
{
    /// <summary>
    /// Значение аргумента подстановки
    /// </summary>
    public class SubstitutionArgumentValue
    {
        public int Id { get; set; }

        /// <summary>
        /// Аргумент подстановки, с которым связано значение 
        /// <see cref="SubstitutionArgument"/>
        /// </summary>
        public int ArgumentId { get; set; }

        /// <summary>
        /// Определяет константное значение аргумента.
        /// </summary>
        public string Value { get; set; }
    }
}