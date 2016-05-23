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
        /// Ссылка на аргумент подстановки, с которым связано значение 
        /// </summary>
        public SubstitutionArgument Argument { get; set; }

        /// <summary>
        /// Определяет значение аргумента.
        /// </summary>
        public string Value { get; set; }
    }
}