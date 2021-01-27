using System;
using System.Collections.Generic;
using System.Text;

namespace NAGetInfo
{
 public class Record
    {
        public object title { get; set; }
        public Scopecontent scopeContent { get; set; }

        public Heldby[] heldBy { get; set; }

        public string citableReference { get; set; }

    }
}





public class Scopecontent
{
    public object[] placeNames { get; set; }
    public string description { get; set; }
    public object ephemera { get; set; }
    public object schema { get; set; }
}

public class Heldby
{
    public string xReferenceId { get; set; }
    public string xReferenceCode { get; set; }
    public string xReferenceName { get; set; }
    public object xReferenceType { get; set; }
    public object xReferenceURL { get; set; }
    public object xReferenceDescription { get; set; }
    public object xReferenceSortWord { get; set; }
}





