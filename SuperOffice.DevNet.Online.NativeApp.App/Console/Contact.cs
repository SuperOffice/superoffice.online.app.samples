using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nativeapp.console
{
    public class Contact
    {
        public int ActiveErpLinks { get; set; }
        public int ActiveInterests { get; set; }
        public int ContactId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Deleted { get; set; }
        public string Department { get; set; }
        public string Description { get; set; }
        public int GroupId { get; set; }
        public string OrgNr { get; set; }
        public string Name { get; set; }
        public bool NoMailing { get; set; }
        public string Number1 { get; set; }
        public string Number2 { get; set; }
        public int Source { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool Xstop { get; set; }
    }

}
