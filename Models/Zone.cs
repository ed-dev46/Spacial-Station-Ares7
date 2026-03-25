namespace Spacial_Station_Ares7.Models;

public class Zone
{
    List<StationModule> modules = new List<StationModule>();
    public bool IsOperational => 
        modules.Any(m => m.Module == ModulesEnum.OXYGEN) && 
        modules.Any(m => m.Module == ModulesEnum.POWER);
    private int maxModulesLimit = 4;
    public int Capacity => modules.OfType<BedroomModule>()
                            .Sum(m => m.capacity);

    public void AddModule(StationModule module)
    {
        if (modules.Count() >= maxModulesLimit)
        {
            throw new ArgumentOutOfRangeException("The area is already full. Build another zone.");
        }

        modules.Add(module);
    }
}
/*
zones (agrupamento de modulos)
- precisa ter um modulo de energia e oxigenio para ser operante ok
- limite de 4 modulos em qualquer combinacao ok
- modulo de energia fornece energia para que os modulos da zona funcionem
- cada funcao de um modulo consome energia, quando zerada, a central deve fornecer energia, mesma coisa com oxigenio
*/