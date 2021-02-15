using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Authentication.Core.Entities
{
    public class JsonResponse
    {
        [Key]
        public int DBResponse { get; set; }
    }
}
