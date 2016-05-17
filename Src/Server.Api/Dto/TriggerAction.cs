using System.Collections.Generic;
using Kurs.Api.Server.Data;

namespace Kurs.Api.Server.Dto
{
    /// <summary>
    /// ������� �� �������, ������������ � ��������.
    /// ����� ��������, ����������� ������������� �������� ���������� � ��������� �����������
    /// </summary>
    public class TriggerAction
    {
        public int Id { get; set; }

        /// <summary>
        /// ������ �� ��������� ������� ��������, ������� ���������� ���������
        /// <see cref="IAttributeDescriptor"/>
        /// </summary>
        public int DescriptorId { get; set; }

        /// <summary>
        /// �������, �������� ����� ���������� �������
        /// <see cref="IAdapter"/>
        /// </summary>
        public int AdapterId { get; set; }

        /// <summary>
        /// ������������� ��������� ����������� ��� ��������������� ������������ ���������� �������
        /// </summary>
        public IEnumerable<int> SubstitutionIds { get; set; }

        /// <summary>
        /// ���������������� ��������� �������
        /// </summary>
        public IEnumerable<TriggerActionArgument> Arguments { get; set; }
    }
}