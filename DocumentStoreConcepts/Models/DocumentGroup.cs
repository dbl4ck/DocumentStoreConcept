using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentStoreConcepts.Models
{
    public class DocumentGroup
    {
        public string GroupRef { get; set; }
        public String Type { get; set; }
        public DateTime Delivered { get; set; }
        public List<Document> Documents { get; set; }

        public int DocumentCount 
        {
            get
            {
                if (Documents == null)
                    return 0;

                return Documents.Count;
            }
        }

    }
}
