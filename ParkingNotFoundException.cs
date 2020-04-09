using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsLab2
/// <summary>
/// Класс-ошибка "Если не найден трактор по определенному месту"
/// </summary>
{
    public class ParkingNotFoundException : Exception
    {
        public ParkingNotFoundException(int i) : base("Не найден трактор по месту " + i)
        { }
    }
}
