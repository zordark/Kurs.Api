namespace Kurs.Api.Server.Data
{
    public interface ISubstitutionOutputArgument : ISubstitutionArgument
    {
        /// <summary>
        /// ������ �� ������� ��������, �� �������� ����� ������������� ������� �������� ��� ����� ���������
        /// �� null ������ �����, ����� ���� ����������� � ������ AutoMapping
        /// </summary>
        ISubstitutionInputArgument LinkedInputArgument { get; }
    }
}