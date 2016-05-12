using System.Collections.Generic;

namespace Kurs.Api.Data
{
    /// <summary>
    /// ����� ��������� ����� ������� � ��������������� �� �������� �������� ����������
    /// </summary>
    public class SubstitutionArgumentValuesSet
    {
        public int Id { get; set; }

        public int Order { get; set; }

        public IEnumerable<SubstitutionInputArgumentValue> InputValues { get; set; }

        public IEnumerable<SubstitutionOutputArgumentValue> OutputValues { get; set; }

    }
}