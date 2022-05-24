using System;
using System.Collections.Generic;

#nullable disable

namespace PersonnelRecordsServer.db
{
    public partial class Archive
    {
        public int Id { get; set; }
        public string OldRecord { get; set; }
        public string NewRecord { get; set; }
        public string Note { get; set; }
        public int? ImpactTypeID { get; set; }
        public int? WorkerID { get; set; }
        public int? IsRemuved { get; set; }
        public int? StaffingID { get; set; }
        public DateTime? DateArchive { get; set; }
        public int? IdRecord { get; set; }
    }
}
