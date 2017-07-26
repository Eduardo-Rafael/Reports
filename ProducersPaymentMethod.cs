namespace Reports
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ProducersPaymentMethod
    {
        [StringLength(255)]
        public string Method { get; set; }

        [StringLength(10)]
        public string Lang { get; set; }

        [StringLength(10)]
        public string Status { get; set; }

        public int id { get; set; }

        public DateTime? inserted { get; set; }

        public bool? Patriarch { get; set; }
    }
}
