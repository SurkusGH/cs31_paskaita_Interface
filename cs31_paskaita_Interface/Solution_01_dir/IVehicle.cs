﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs31_paskaita_Interface
{
    public interface IVehicle
    {
        // Sukurkite interface’ą pavadinimų IVehicle su metodais Drive ir Refuel
        // (grąžinimo tipą galit pasirinkti patys ir tai kaip jį implementuosit, galite daryti ir su void)
        public void Drive();
        public void Refuel();
    }
}
