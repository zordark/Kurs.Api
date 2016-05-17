namespace Kurs.Api.Server.Data
{
    /// <summary>
    /// �������� �������� ��������� �����������
    /// </summary>
    public interface ISubstitutionInputArgumentValue
    {
        int Id { get; }

        ISubstitutionInputArgument Argument { get; }

        /// <summary>
        /// �������� �������� ��������� �����������.
        /// </summary>
        string Value { get; set; }
    }
}