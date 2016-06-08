using System.Collections.Generic;

namespace Kurs.Api.Server.Services
{
    public class SubstitutionValidationErrors
    {
        /// <summary>
        /// ���� �� ������ ���������
        /// </summary>
        public bool IsHaveErrors { get; set; }

        /// <summary>
        /// ������ � ����� �����������
        /// </summary>
        public string NameError { get; set; }

        /// <summary>
        /// ������ ���������� ������ ������������
        /// </summary>
        public string AutoMappingError { get; set; }

        /// <summary>
        /// ������ �� ������� ����������
        /// </summary>
        public string InputArgumentsError { get; set; }

        /// <summary>
        /// ������ � �������� ����������
        /// </summary>
        public string OutputArgumentsError { get; set; }

        /// <summary>
        /// ����� ������ � ��������� �������� �����������
        /// </summary>
        public Dictionary<int, string> ArgumentValuesErrors { get; set; } = new Dictionary<int, string>();
    }

//    public class SubstitutionValidationErrors
//    {
//        /// <summary>
//        /// ���� �� ������ ���������
//        /// </summary>
//        public bool IsHaveErrors { get; set; }
//
//        /// <summary>
//        /// ������ � ����� �����������
//        /// </summary>
//        
//
//        /// <summary>
//        /// ����� ������ � ��������� �������� �����������
//        /// </summary>
//        public Dictionary<int, string> ArgumentValuesErrors { get; set; } = new Dictionary<int, string>();
//
//        public enum ErrorCodes
//        {
//            NameAlreadyExist,
//            NameIsNull,
//
//        }
//    }
}