using ModelApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonnelRecordsServer.db
{
    public partial class Archive
    {
        public static explicit operator ArchiveApi(Archive archive)
        {
            return new ArchiveApi
            {
                Id = archive.Id,
                //MakedDate = archive.MakedDate,
                OneRecord = archive.OneRecord,
                TwoRecord = archive.TwoRecord,
                ThreeRecord = archive.ThreeRecord,
                FourRecord = archive.FourRecord,
                FiveRecord = archive.FiveRecord,
                SixRecord = archive.SixRemuved,
                SevenRecord = archive.SevenRecord,
                EightRecord = archive.EightArchive,
                NineRecord = archive.NineRecord,
                TenRecord = archive.TenRecord,
                DateRecord = archive.DateRecord


            };
        }

        public static explicit operator Archive(ArchiveApi archive)
        {
            return new Archive
            {
                Id = archive.Id,
                //MakedDate = archive.MakedDate,
                OneRecord = archive.OneRecord,
                TwoRecord = archive.TwoRecord,
                ThreeRecord = archive.ThreeRecord,
                FourRecord = archive.FourRecord,
                FiveRecord = archive.FiveRecord,
                SixRemuved = archive.SixRecord,
                SevenRecord = archive.SevenRecord,
                EightArchive = archive.EightRecord,
                NineRecord = archive.NineRecord,
                TenRecord = archive.TenRecord,
                DateRecord = archive.DateRecord,
            };
        }
    }
}
