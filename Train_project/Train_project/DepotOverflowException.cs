using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train_project
{
    /// <summary>
    /// Класс-ошибка "Если в депо уже заняты все места"
    /// </summary>
    class DepotOverflowException : Exception
    {
        public DepotOverflowException() : base("В депо нет свободных мест")
        { }
    }
}
