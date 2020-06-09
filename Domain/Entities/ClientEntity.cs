using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class ClientEntity : BaseEntity
    {
        public string Name { get; set; }

        public int Age { get; set; }
    }
}
