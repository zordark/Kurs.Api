using System;
using System.Collections.Generic;
using Kurs.Api.Data;

namespace Kurs.Api
{
    public interface IAdapterInfoService
    {
        IEnumerable<AdapterInfo> Read();

        void UploadUpdate(Guid adapterId, byte[] updateFile);

        void ApplyUpdate(Guid adapterId);
    }
}