using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train_project
{
    class DepotAlreadyHaveException : Exception
    {
        public DepotAlreadyHaveException() : base("В депо уже есть такой поезд")
        { }
    }
}
