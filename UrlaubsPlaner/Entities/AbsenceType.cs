using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrlaubsPlaner.Entities
{
    public class AbsenceType : IUpsertable
    {
        public Guid AbsenceTypeId { get; set; }
        public string Label { get; set; }

        public AbsenceType()
        {
        }

        public override string ToString()
        {
            return $"{Label}";
        }
    }
}