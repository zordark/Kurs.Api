namespace Kurs.Api.Data
{
    /// <summary>
    /// Значение выходного аргумента подстановки
    /// </summary>
    public class SubstitutionInputArgumentValue
    {
        public int Id { get; set; }

        public SubstitutionInputArgument Argument { get; set; }

        public string Value { get; set; }
    }
}