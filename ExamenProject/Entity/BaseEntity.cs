using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenProject.Entity
{
    public class BaseEntity
    {
        public Int32 Id { get; set; }
        public String TranslateKey { get; set; }
        public String TranslateValue { get; set; }
        public Int16 Status { get; set; }
    }
}