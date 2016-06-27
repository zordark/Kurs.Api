namespace Kurs.Api.Server.Settings
{
    public class BrokerSettings
    {
        /// <summary>
        /// ID ПАК КУРС
        /// Уникальный идентификатор системы в сети ПАК КУРС. Уникальность необходимо обеспечить только для систем ПАК КУРС, объединяемых в одну сеть.
        /// </summary>
        public string KursId { get; set; }
        public string KursName { get; set; }

        public EsbPublicSettings PublicSettings { get; set; }

        public EsbPrivateSettings PrivateSettings { get; set; }

        public EsbAdminSettings AdminSettings { get; set; }
    }
}