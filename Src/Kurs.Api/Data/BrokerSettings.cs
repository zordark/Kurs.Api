namespace Kurs.Api.Data
{
    public class BrokerSettings
    {
        /// <summary>
        /// Уникальный идентификатор системы в сети ПАК КУРС. 
        /// Уникальность необходимо обеспечить только для систем ПАК КУРС, объединяемых в одну сеть.
        /// </summary>
        public string KursId { get; set; }

        public EsbPublicSettings PublicSettings { get; set; }

        public EsbPrivateSettings PrivateSettings { get; set; }
    }
}