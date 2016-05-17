using System;

namespace Kurs.Api.Server.Settings
{
    public class EsbNodeSettings
    {
        /// <summary>
        /// ID ������� ��� ����
        /// </summary>
        public string KursId { get; set; }

        /// <summary>
        /// ������������ �������
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// URL ���������� ������� ����. ������: http://RabbitMQ-������:����/����
        /// </summary>
        public Uri Uri { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        /// <summary>
        /// ��������� ���� ���� � �������� �� ��������� � ���
        /// </summary>
        public EsbNodePlacement Placement { get; set; }
    }
}