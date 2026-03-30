namespace Spacial_Station_Ares7.Models;

public class Zone
{

    public int Id { get; }
    public string Name { get; }
    List<StationModule> modules = new List<StationModule>();
    public bool IsOperational => 
        modules.Any(m => m.Module == ModulesEnum.OXYGEN) && 
        modules.Any(m => m.Module == ModulesEnum.POWER);

    private int maxModulesLimit = 4;
    public int Capacity => modules.OfType<BedroomModule>()
                            .Sum(m => m.capacity);
    public int EnergyLevel { get; private set; } = 0;

    public Zone(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public void AddModule(StationModule module)
    {
        if (modules.Count() >= maxModulesLimit)
        {
            throw new ArgumentOutOfRangeException("The area is already full. Build another zone.");
        }

        modules.Add(module);
    }

    public void ChargeEnergyLevel()
    {
        if (modules.Any(m => m.Module == ModulesEnum.POWER))
        {
            EnergyLevel = 100;
        } else
        {
            throw new MissingMemberException("The zone does not have a Power Module to Charge Up.");
        }
    }

    public override string ToString()
    {
        string str = $"| {Name} | {Id} | {EnergyLevel}% \n";
        if (!modules.Any())
        {
            str += "The zone is empty of modules.";
        } else
        {
            foreach(var module in modules)
            {
               str += $"{module}\n";
            }
        }
        str += "\n-------------------------";
        return str;
    }
}
/*
zones (agrupamento de modulos)
- precisa ter um modulo de energia e oxigenio para ser operante ok
- limite de 4 modulos em qualquer combinacao ok
- modulo de energia fornece energia para que os modulos da zona funcionem
- cada funcao de um modulo consome energia, quando zerada, a central deve fornecer energia, mesma coisa com oxigenio
*/