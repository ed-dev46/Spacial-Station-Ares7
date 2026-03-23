namespace Spacial_Station_Ares7.Models;

public class PowerModule : StationModule
{
    
    public PowerModule(int id, string name) : base(id, name)
    {
        Module = ModulesEnum.POWER;
    }
}
