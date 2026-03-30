namespace Spacial_Station_Ares7.Models;

public abstract class StationModule
{
    public int Id { get; }
    public string Name { get; }
    public ModulesEnum Module { get; set; }

    public StationModule(int id, string name)
    {
        Id = id;
        Name = name.ToUpper();
    }

    public override string ToString()
    {
        return $"| Module: {Module} | Id: {Id} - {Name}";
    }
}
