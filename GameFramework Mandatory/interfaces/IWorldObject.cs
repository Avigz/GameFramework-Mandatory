namespace GameFramework_Mandatory
{


    public interface IWorldObject
    {
        string Name { get; set; }
        Position Position { get; set; }
        object InternalObject { get; set; }
        
    }
}