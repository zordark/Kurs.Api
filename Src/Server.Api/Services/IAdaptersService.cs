using System.Collections.Generic;
using Kurs.Api.Server.Data;
using Kurs.Api.Services;

namespace Kurs.Api.Server.Services
{
    public interface IAdaptersService : IKursApiService
    {
        /// <summary>
        /// Список всех адаптеров
        /// </summary>
        /// <returns></returns>
        IEnumerable<IAdapter> Adapters { get; }

        void UploadUpdate( int adapterId, byte[] updateFile );

        void ApplyUpdate( int adapterId );
    }
}