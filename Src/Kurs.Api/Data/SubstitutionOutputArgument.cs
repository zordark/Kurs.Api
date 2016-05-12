namespace Kurs.Api.Data
{
    /// <summary>
    /// Выходной аргумент подстановки
    /// </summary>
    public class SubstitutionOutputArgument : SubstitutionArgument
    {
        /// <summary>
        /// Входной аргумент подстановки, с которым связан выходной.
        /// Задается только для подстановок у которых установлен флаг IsAttributesShouldBeMapped
        /// </summary>
        public SubstitutionInputArgument LinkedInputArgument { get; set; }
    }
}