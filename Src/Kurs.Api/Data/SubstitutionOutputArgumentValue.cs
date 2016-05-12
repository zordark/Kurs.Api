namespace Kurs.Api.Data
{
    /// <summary>
    /// Значение выходного аргумента подстановки
    /// </summary>
    public class SubstitutionOutputArgumentValue
    {
        public int Id { get; set; }

        /// <summary>
        /// Аргумент команды с которым связано значение 
        /// </summary>
        public SubstitutionOutputArgument Argument { get; set; }

        /// <summary>
        /// Определяет константное значение аргумента команды.
        /// </summary>
        public string Value { get; set; }
    }
}