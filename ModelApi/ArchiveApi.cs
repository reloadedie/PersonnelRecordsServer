using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelApi
{
    public class ArchiveApi : ApiBaseType
    {
        //public DateTime? MakedDate { get; set; }
        public string NewRecord { get; set; }
        public string OldRecord { get; set; }
        public string Note { get; set; }
        public int? ImpactTypeID { get; set; }
        public int? WorkerID { get; set; }
        public int IsRemuved { get; set; }
        public int? StaffingID { get; set; }        
        public DateTime? DateArchive { get; set; }       
       
    }
}
