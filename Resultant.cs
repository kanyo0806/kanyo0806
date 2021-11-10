using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BidvestData.Common.Models
{
    public class Resultant<T>:Resultant
    {
        public T Data { get; set; }
    }

    public class Resultant {
        public bool Success => !this.Messages.Any();
        public List<string> Messages { get; set; } = new List<string>();
    }
}
