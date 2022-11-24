using health_calc_pack_dotnet_erika_fernandes.Enums;
using health_calc_pack_dotnet_erika_fernandes.Models;

namespace health_calc_pack_dotnet_erika_fernandes.Interfaces
{

    public interface IMacronutriente

    {
        MacronutrienteModel Calc(
            SexoEnum sexo,
            double Height,
            double Weight,
            NivelAtividadeFisicaEnum nivelAtividadeFisica,
            ObjetivoFisicoEnum objetivoFisico);

        bool IsValidData(double Weight);


    }
}

