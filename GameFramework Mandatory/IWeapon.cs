﻿namespace GameFramework_Mandatory
{
    public interface IWeapon
    {
        double MaxDamage { get; set; }
        double MinDamage { get; set; }
        bool TwoHanded { get; set; }

        int DoAttack();
    }
}