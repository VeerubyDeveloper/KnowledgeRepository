using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData 
{
    public string display1;
    public string display2;

    public PlayerData (Player player)
    {
        display1 = player.AnchorID;
        display2 = player.AnchorName;
    }
}

