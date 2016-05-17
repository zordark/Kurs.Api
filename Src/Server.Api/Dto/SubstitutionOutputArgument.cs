namespace Kurs.Api.Server.Dto
{
    /// <summary>
    /// �������� �������� �����������
    /// </summary>
    public class SubstitutionOutputArgument : SubstitutionArgument
    {
        /// <summary>
        /// ������� �������� �����������, � ������� ������ ��������.
        /// �������� ������ ��� �����������, � ������� ���������� ���� AutoMapping
        /// <see cref="SubstitutionInputArgument"/>
        /// </summary>
        public int LinkedInputArgumentId { get; set; }
    }
}