using System;

namespace Kurs.Api.Data
{
    public class EsbNodeSettings
    {
        public string KursId { get; set; }

        public string Name { get; set; }

        public Uri Uri { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public EsbNodePlacement Placement { get; set; }
    }
}