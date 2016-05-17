namespace Kurs.Api.Server.Data
{
    /// <summary>
    /// Значение входного аргумента подстановки
    /// </summary>
    public interface ISubstitutionInputArgumentValue
    {
        int Id { get; }

        ISubstitutionInputArgument Argument { get; }

        /// <summary>
        /// Значение входного аргумента подстановки.
        /// </summary>
        string Value { get; set; }
    }
}