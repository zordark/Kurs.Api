using System;
using System.Collections.Generic;

namespace Kurs.Api.Server.Dto
{
    public class Substitution
    {
        /// <summary>
        /// ������������� ����������� 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// �������� �����������
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// ������� ����, ��� ����������� ������ ������������� ������ ������� ��������� � ��������, ��� ����
        /// ���������� ������ ������ ����� ������� � �������� ����������, ���������� ������� � �������� ���������� ������ ���������,
        /// ������� �������� ��������� ����� ��������������� �������� �������� �������� ��������� �������.
        /// ���� AutoMapping �������, �� ����� �������� ���������� �� ��������.
        /// </summary>
        public bool AutoMapping { get; set; }

        /// <summary>
        /// ����� ������� ���������� ����������� 
        /// </summary>
        public IEnumerable<SubstitutionArgument> InputArguments { get; set; }

        /// <summary>
        /// ����� �������� ���������� �����������
        /// </summary>
        public IEnumerable<SubstitutionArgument> OutputArguments { get; set; }

        /// <summary>
        /// ����� �������� ������� � ��������������� �� ����� �������� �������� ����������.
        /// �������� ������ � ������, ���� AutoMapping = false
        /// </summary>
        public IEnumerable<SubstitutionArgumentValuesSet> ArgumentValues { get; set; }


//        /// <summary>
//        /// ����� ������� ���������� ����������� (AttributeDescriptorID)
//        /// </summary>
//        public IEnumerable<int> InputArguments { get; set; }
//
//        /// <summary>
//        /// ����� �������� ���������� ����������� (AttributeDescriptorID)
//        /// </summary>
//        public IEnumerable<int> OutputArguments { get; set; }
//
//        /// <summary>
//        /// ����� �������� ������� � ��������������� �� ����� �������� �������� ����������.
//        /// �������� ������ � ������, ���� AutoMapping = false
//        /// </summary>
//        public IEnumerable<Dictionary<int,string>> ArgumentValues { get; set; }
    }
}