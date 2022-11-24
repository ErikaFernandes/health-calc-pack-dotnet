using System;
using health_calc_pack_dotnet_erika_fernandes.Interfaces;
using health_calc_pack_dotnet_erika_fernandes.Models;

namespace health_calc_pack_dotnet_erika_fernandes
{
    public class MacronutrienteContex
    {
        private IMacronutrienteStrategy MacronutrienteStrategy;

        public MacronutrienteContex(IMacronutrienteStrategy Strategy)
        {
            MacronutrienteStrategy = Strategy;
        }

        public void SetStrategy(IMacronutrienteStrategy Strategy)
        {
            MacronutrienteStrategy = Strategy;
        }

        public MacronutrienteModel Execute(double Weight)

        {
            return MacronutrienteStrategy.Calc(Weight);
        }


       
    }
}

