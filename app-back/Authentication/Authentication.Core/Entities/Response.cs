using System;
using System.Collections.Generic;
using System.Text;

namespace Authentication.Core.Entities
{
    public class Response
    {
        public int code { get; set; }
        public string messsage { get; set; }
        public object content { get; set; }
    }
}
