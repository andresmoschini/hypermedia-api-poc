﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using Microsoft.AspNet.Mvc;
using System.Linq.Expressions;
using System.Reflection;

namespace ApiPoc.Representations
{
    public class LinkRepresentation
    {
        public string Href { get; set; }

        public string Rel { get; set; }
        
        public static LinkRepresentation AccountHome(string href)
        {
            return new LinkRepresentation() { Href = href, Rel = "ClientHome" };
        }

    }
   
}