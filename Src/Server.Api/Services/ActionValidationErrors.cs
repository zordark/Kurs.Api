using System.Collections.Generic;

namespace Kurs.Api.Server.Services
{
    public class ActionValidationErrors
    {
        /// <summary>
        /// ����� ������ ��������� ��������. � �������� ����� ������ ��� ������������ ��������, � � ������ �� ���������-���������� "name#index"
        /// </summary>
        public Dictionary<string, ErrorCodes> Errors { get; } = new Dictionary<string, ErrorCodes>();

        public enum ErrorCodes
        {
            /// <summary>
            /// ��������� ���������� �������� �� ����������
            /// </summary>
            TriggerDescriptorNotExist,

            /// <summary>
            /// ������ ������� �� ����������
            /// </summary>
            AdapterNotExist,

            /// <summary>
            /// ��������� ���������� ������� �������� �� ����������
            /// </summary>
            DescriptorNotExist,

            /// <summary>
            /// ������ ������������ ���������� ������� ��������
            /// </summary>
            DescriptorInvalid,

            /// <summary>
            /// ��������� ����������� �� ����������
            /// </summary>
            SubstitutionNotExist,

            /// <summary>
            /// ��������� ����������� �� ���������
            /// </summary>
            SubstitutionInvalid,

            /// <summary>
            /// ���������� ��� ��������� �������� �� ����������
            /// </summary>
            ArgumentDescriptorNotExist,

            /// <summary>
            /// �������� �������� �������, �� ��� ���� �� ����� ������ �� ��������
            /// </summary>
            ArgumentInvalidValue,

            
        }
    }
}