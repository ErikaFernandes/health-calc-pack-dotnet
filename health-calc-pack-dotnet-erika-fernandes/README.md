# health-calc-pack-dotnet

health-calc-pack-dotnet is a C# library for dealing health purposes calculating the IMC and macronutrients.

## Installation

Use Nuget to get the health-calc-pack-dotnet-erika-fernandes library.



 Usage

 ## IMC: 

 ## Call calc to get the IMC value.
```
Calc(double Height, double Weight)
```
 

 ## Call GetIMCCategory to get the IMC category.  
```
GetIMCCategory(double IMC)
```
 

 ## Macronutrients:

 ## Call Calc to get the Macronutrients value.

```
Calc(SexoEnum Sexo,
             double Height,
             double Weight,
             NivelAtividadeFisicaEnum nivelAtividadeFisica,
             ObjetivoFisicoEnum objetivoFisico)
        {
```



## Contributing

Pull requests are welcome. For major changes, please open an issue first
to discuss what you would like to change.

Please make sure to update tests as appropriate.
