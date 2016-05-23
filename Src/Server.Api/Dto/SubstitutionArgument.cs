using System;
using Kurs.Api.Server.Data;

namespace Kurs.Api.Server.Dto
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
        /// ��������� ��������, � ������� ������ �������� �����������.
        /// <see cref="IAttributeDescriptor"/>
        /// </summary>
        public int AddributeDescriptorId { get; set; }

        /// <summary>
        /// ������� ���������� ���������
        /// </summary>
        public int Order { get; set; }
    }
}