using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using WebApplication1TidTilForsikringApp.Enums;

namespace WebApplication1TidTilForsikringApp.Models
{
    [DataContract]
    public class Outputs
    {
        public X _X { get; set; }

        [DataMember]
        public string X
        {
            get
            {
                return this._X.ToString();
            }
        }

        [DataMember]
        public decimal Y { get; set; }
    }
}