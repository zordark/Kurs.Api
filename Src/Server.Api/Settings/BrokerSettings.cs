namespace Kurs.Api.Server.Settings
{
    public class BrokerSettings
    {
        /// <summary>
        /// ID ��� ����
        /// ���������� ������������� ������� � ���� ��� ����. ������������ ���������� ���������� ������ ��� ������ ��� ����, ������������ � ���� ����.
        /// </summary>
        public string KursId { get; set; }
        public string KursName { get; set; }

        public EsbPublicSettings PublicSettings { get; set; }

        public EsbPrivateSettings PrivateSettings { get; set; }

        public EsbAdminSettings AdminSettings { get; set; }
    }
}