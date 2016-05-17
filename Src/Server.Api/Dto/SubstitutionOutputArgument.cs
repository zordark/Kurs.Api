namespace Kurs.Api.Server.Dto
{
    /// <summary>
    /// ¬ыходной аргумент подстановки
    /// </summary>
    public class SubstitutionOutputArgument : SubstitutionArgument
    {
        /// <summary>
        /// ¬ходной аргумент подстановки, с которым св€зан выходной.
        /// «адаетс€ только дл€ подстановок, у которых установлен флаг AutoMapping
        /// <see cref="SubstitutionInputArgument"/>
        /// </summary>
        public int LinkedInputArgumentId { get; set; }
    }
}