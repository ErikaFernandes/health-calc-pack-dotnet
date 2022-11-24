using health_calc_pack_dotnet_erika_fernandes.Enums;
using health_calc_pack_dotnet_erika_fernandes.Models;

namespace health_calc_pack_dotnet_erika_fernandes.Interfaces
{
    public interface IMacronutrienteStrategy
    {
        MacronutrienteModel Calc(double Weight);            
    }
}

