namespace Kurs.Api.Data
{
    /// <summary>
    /// �������� ��������� �����������
    /// </summary>
    public class SubstitutionArgument
    {
        /// <summary>
        /// ������������� ��������� ����������� 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// ��������� �������� � ������� ������ �������� �����������
        /// </summary>
        public AttributeDescriptor Descriptor { get; set; }

        /// <summary>
        /// ������� ���������� ��������� (������ ��� UI)
        /// </summary>
        public int Order { get; set; }
    }
}