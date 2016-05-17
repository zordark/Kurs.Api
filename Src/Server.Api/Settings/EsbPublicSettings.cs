using System;

namespace Kurs.Api.Server.Settings
{
    /// <summary>
    /// ��������� ������� ��������������
    /// </summary>
    public class EsbPublicSettings
    {
        /// <summary>
        /// URL ��� ����������� � ������� ��������������.
        /// ������: amqp://������-��������������:����/����
        /// </summary>
        public Uri ConnectionUri { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }
    }
}