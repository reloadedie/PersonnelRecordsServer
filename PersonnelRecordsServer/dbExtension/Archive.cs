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
                NewRecord = archive.NewRecord,
                OldRecord = archive.OldRecord,
                Note = archive.Note,
                DateArchive = archive.DateArchive,
                StaffingID = archive.StaffingID,
                ImpactTypeID = archive.ImpactTypeID,
                WorkerID = archive.WorkerID
            };
        }

        public static explicit operator Archive(ArchiveApi archive)
        {
            return new Archive
            {
                Id = archive.Id,
                //MakedDate = archive.MakedDate,
                NewRecord = archive.NewRecord,
                OldRecord = archive.OldRecord,
                Note = archive.Note,
                DateArchive = archive.DateArchive,
                StaffingID = archive.StaffingID,
                ImpactTypeID = archive.ImpactTypeID,
                WorkerID = archive.WorkerID
            };
        }
    }
}
