using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train_project
{
    /// <summary>
    /// Класс-ошибка "Если не найден поезд по определенному месту"
    /// </summary>
    class DepotNotFoundException : Exception
    {
        public DepotNotFoundException(int i) : base("Не найден поезд по месту " + i)
        { }
    }
}
