using System;
using health_calc_pack_dotnet_erika_fernandes;

namespace health_calc_pack_dotnet_erika_fernandes
{
    public interface IIMC

    {
        double Calc(double Height, double Weight);

        string GetIMCCategory(double IMC);

        bool IsValidData(double Height, double Weight);
       
    }
}

