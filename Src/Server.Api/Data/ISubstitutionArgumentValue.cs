namespace Kurs.Api.Server.Data
{
    /// <summary>
    /// Значение аргумента подстановки
    /// </summary>
    public interface ISubstitutionArgumentValue
    {
        int Id { get; }

        ISubstitutionArgument Argument { get; }

        /// <summary>
        /// Значение входного аргумента подстановки.
        /// </summary>
        string Value { get; }

        /// <summary>
        /// Значение входного аргумента подстановки.
        /// </summary>
        string DisplayValue { get; }
    }
}