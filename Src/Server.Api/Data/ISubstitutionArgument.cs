namespace Kurs.Api.Server.Data
{
    /// <summary>
    /// �������� ��������� �����������
    /// </summary>
    public interface ISubstitutionArgument
    {
        /// <summary>
        /// ������������� ��������� ����������� 
        /// </summary>
        int Id { get; }

        /// <summary>
        /// ��������� �������� � ������� ������ �������� �����������
        /// </summary>
        IAttributeDescriptor Descriptor { get; }

        /// <summary>
        /// ������� ���������� ��������� (��� UI)
        /// </summary>
        int Order { get; }
    }
}