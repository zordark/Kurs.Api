using System.Collections.Generic;

namespace Kurs.Api.Server.Dto
{
    /// <summary>
    /// ����� ��������� ����� ������� � ��������������� �� �������� �������� ����������
    /// </summary>
    public class SubstitutionArgumentValuesSet
    {
        public int Id { get; set; }

        /// <summary>
        /// ������� ���������� (��� UI)
        /// </summary>
        public int Order { get; set; }

        public IEnumerable<SubstitutionArgumentValue> InputValues { get; set; }
    }
}