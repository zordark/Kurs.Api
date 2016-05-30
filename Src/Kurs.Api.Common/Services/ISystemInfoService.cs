using System.Collections.Generic;

namespace Kurs.Api.Services
{
    public interface ISystemInfoService : IKursApiService
    {
        /// <summary>
        /// ��������� ������ ������������������ ���������
        /// </summary>
        /// <returns></returns>
        IEnumerable<AdapterDescriptor> GetRegisteredAdapters();

        /// <summary>
        /// ����� ��������� ���������� � �������
        /// </summary>
        /// <returns></returns>
        SystemDescriptor GetSystemDescriptor();

    }
}