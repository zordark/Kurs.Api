namespace Kurs.Api.Server.Data
{
    public interface ISubstitutionOutputArgument : ISubstitutionArgument
    {
        /// <summary>
        /// —сылка на входной аргумент, из которого будет автоматически братьс€ значение дл€ этого аргумента
        /// Ќе null только тогда, когда сама подстановка в режиме AutoMapping
        /// </summary>
        ISubstitutionInputArgument LinkedInputArgument { get; }
    }
}