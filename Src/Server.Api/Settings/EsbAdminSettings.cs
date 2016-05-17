using System;

namespace Kurs.Api.Server.Settings
{
    /// <summary>
    /// ��������� ���������� ����� ��������� RabbitMQ
    /// </summary>
    public class EsbAdminSettings
    {
        /// <summary>
        /// URL HTTP API RabbitMq.
        /// ������: amqp://������-RabbitMQ:����
        /// </summary>
        public Uri ConnectionUri { get; set; }

        /// <summary>
        /// ��� ������������ (��������������) ��� ���������� �����
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// ������ ��������������
        /// </summary>
        public string Password { get; set; }
    }
}