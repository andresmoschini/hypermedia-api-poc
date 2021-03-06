﻿using System;

namespace ApiPoc.Representations
{
    public class Link
    {
        public string Href { get; set; }

        public string Description { get; set; }

        public Rel Rel { get; set; }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hash = 17; // Suitable nullity checks etc, of course :)
                hash = hash * 23 + (Href == null ? 587 : Href.GetHashCode());
                hash = hash * 23 + Rel.GetHashCode();
                hash = hash * 23 + (Description == null ? 587 : Description.GetHashCode());
                return hash;
            }
        }
    }
}
