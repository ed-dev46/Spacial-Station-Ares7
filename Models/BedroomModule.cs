namespace Spacial_Station_Ares7.Models;

public class BedroomModule : StationModule
{
    public int capacity;
    public BedroomModule(int id, string name, int capacity) : base(id, name)
    {
        Module = ModulesEnum.BEDROOM;
        this.capacity = capacity;
    }
}
