﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Web;

namespace Vidly.Models
{
    // bl
    public class MembershipType
    {
        public byte Id { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }

        public string test { get; set; }

    }
}
