namespace GameFramework_Mandatory.interfaces
{
    public interface IWeapon
    {
        string Name { get; set; }
        double MaxDamage { get; set; }
        double MinDamage { get; set; }
        bool TwoHanded { get; }

        int DoAttack();
    }
}