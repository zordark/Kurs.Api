using System;

namespace Kurs.Api.Server.Data
{
    /// <summary>
    /// «начение выходного аргумента подстановки
    /// </summary>
    public interface ISubstitutionOutputArgumentValue
    {
        int Id { get; }

        /// <summary>
        /// јргумент подстановки, с которым св€зано значение 
        /// </summary>
        ISubstitutionOutputArgument Argument { get; }

        /// <summary>
        /// «начение выходного аргумента подстановки.
        /// </summary>
        string Value { get; set; }
    }
}