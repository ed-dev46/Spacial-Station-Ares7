namespace Spacial_Station_Ares7.Models;

public class BedroomModule : StationModule
{
    public BedroomModule(int id, string name) : base(id, name)
    {
        Module = ModulesEnum.BEDROOM;
    }
}
