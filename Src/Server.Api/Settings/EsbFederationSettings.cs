using System.Collections.Generic;

namespace Kurs.Api.Server.Settings
{
    /// <summary>
    /// ��������� ���� ������� ��� ����
    /// </summary>
    public class EsbFederationSettings
    {
        /// <summary>
        /// ������� ��� ����
        /// </summary>
        public IEnumerable<EsbNodeSettings> Nodes { get; set; }
    }
}