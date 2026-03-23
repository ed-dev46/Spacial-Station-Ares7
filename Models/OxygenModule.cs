namespace Spacial_Station_Ares7.Models;

public class OxygenModule : StationModule
{
    public OxygenModule(int id, string name) : base(id, name)
    {
        Module = ModulesEnum.OXYGEN;
    }
}
