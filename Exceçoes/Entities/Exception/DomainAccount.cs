using System;
using System.Collections.Generic;
using System.Text;
using Exceçoes.Entities;

namespace Exceçoes.Entities.Excepition
{
    internal class DomainAccount : ApplicationException
    {
        public DomainAccount (string message) : base(message)
        {

        }
    }
}
