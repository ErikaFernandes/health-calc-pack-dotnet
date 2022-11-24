﻿using System;
using health_calc_pack_dotnet_erika_fernandes.Interfaces;
using health_calc_pack_dotnet_erika_fernandes.Models;

namespace health_calc_pack_dotnet_erika_fernandes.Strategy
{
    public class CuttingStrategy : IMacronutrienteStrategy

    {

        const int PROTEINA = 2;
        const int GORDURA = 1;
        const int CARBOIDRATO = 2;


        public MacronutrienteModel Calc(double Weight)

        {

            var Result = new MacronutrienteModel()

            {
                Proteinas = PROTEINA * (int)Weight,
                Carboidratos = CARBOIDRATO * (int)Weight,
                Gorduras = GORDURA * (int)Weight
            };

            return Result;

        }
    }
}
