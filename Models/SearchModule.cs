namespace Spacial_Station_Ares7.Models;

public class SearchModule : StationModule
{
    public SearchModule(int id, string name) : base(id, name)
    {
        Module = ModulesEnum.SEARCH;
    }
}
