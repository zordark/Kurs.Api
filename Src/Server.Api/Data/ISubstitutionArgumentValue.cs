namespace Kurs.Api.Server.Data
{
    /// <summary>
    /// �������� ��������� �����������
    /// </summary>
    public interface ISubstitutionArgumentValue
    {
        int Id { get; }

        ISubstitutionArgument Argument { get; }

        /// <summary>
        /// �������� �������� ��������� �����������.
        /// </summary>
        string Value { get; }

        /// <summary>
        /// �������� �������� ��������� �����������.
        /// </summary>
        string DisplayValue { get; }
    }
}