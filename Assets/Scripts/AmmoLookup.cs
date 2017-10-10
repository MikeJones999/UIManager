using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class AmmoLookup {


    public static string GetCorrectAmmo(string Weapon, string slot)
    {
        string ammo = "";

        switch (Weapon)
        {
            case "Catapult": switch(slot)
                            {
                             case "Slot1": ammo  = "fire Ball"; break;
                             case "Slot2": ammo = "Ice Ball"; break;
                             }
                             break;
            case "Crossbow": switch (slot)
                            {
                                case "Slot1": ammo = "Fire Bolt"; break;
                                case "Slot2": ammo = "Ice Bolt"; break;
                            }
                            break;

        }

        return ammo;

    }


}
