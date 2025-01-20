using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class EnduranceShape
    {
        public string Endurance { get; set; }


        // Метод для копирования экипировки (глубокая копия)
        public EnduranceShape Clone()
        {
            return new EnduranceShape
            {
                Endurance = this.Endurance,
            };
        }
    }
}
