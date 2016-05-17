using System.Collections.Generic;
using Kurs.Api.Server.Data;

namespace Kurs.Api.Server.Services
{
    public interface IAdaptersService
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