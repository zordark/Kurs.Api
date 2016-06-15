using System.Collections.Generic;

namespace Kurs.Api.Server.Services
{
    public class TriggerValidationErrors
    {
        /// <summary>
        /// ����� ������ ��������� ��������. � �������� ����� ������ ��� ������������ ��������, � � ������ �� ���������-���������� "name#index"
        /// </summary>
        public Dictionary<string, ErrorCodes> Errors { get; } = new Dictionary<string, ErrorCodes>();

        /// <summary>
        /// ������ ��������� �������
        /// </summary>
        public Dictionary<string, ActionValidationErrors> Actions { get; } = new Dictionary<string, ActionValidationErrors>();

        public enum ErrorCodes
        {
            /// <summary>
            /// ������� �� ����������
            /// </summary>
            TriggerNotExist,

            /// <summary>
            /// ������� � ��������� ������ ��� ����������
            /// </summary>
            NameAlreadyExist,

            /// <summary>
            /// ��������� ���������� ������� �������� �� ����������
            /// </summary>
            DescriptorNotExist,

            /// <summary>
            /// ������ ������������ ���������� ������� ��������
            /// </summary>
            DescriptorInvalid,

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