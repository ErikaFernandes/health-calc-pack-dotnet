using System;
using health_calc_pack_dotnet_erika_fernandes.Enums;
using health_calc_pack_dotnet_erika_fernandes.Interfaces;
using health_calc_pack_dotnet_erika_fernandes.Models;
using health_calc_pack_dotnet_erika_fernandes.Strategy.Base;


namespace health_calc_pack_dotnet_erika_fernandes.Strategy
{
    public class BulkingNivelAtividadeAtivoStrategy : MacroNutrienteBase, IMacronutrienteStrategy

    {

        const int PROTEINA = 2;
        const int GORDURA = 2;
        const int CARBOIDRATO = 7;

        public BulkingNivelAtividadeAtivoStrategy(SexoEnum sexo) : base(sexo)

        {

        }
      

        public MacronutrienteModel Calc(double Weight)

        {
          
            var Result = new MacronutrienteModel()

            {
                Proteinas = PROTEINA * (int)Weight * GENDER_MUTIPLIER,
                Carboidratos = CARBOIDRATO * (int)Weight * GENDER_MUTIPLIER,
                Gorduras = GORDURA * (int)Weight * GENDER_MUTIPLIER
            };

            return Result;

        }
    }
}
