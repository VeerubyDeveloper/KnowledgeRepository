using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour
{

    public TMP_InputField input1;
    public TMP_InputField input2;

    [HideInInspector]
    public string AnchorID;
    [HideInInspector]
    public string AnchorName;
    [HideInInspector]
    public string loadID;
    [HideInInspector]
    public string loadname;

    public TMP_Text text1;
    public TMP_Text text2;

    public void SavePlayer()
    {
        AnchorID = input1.text;
        AnchorName = input2.text;
        SaveSystem.SavePlayer(this);
    }
    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        loadID = data.display1;
        loadname = data.display2;
        text1.text = loadID;
        text2.text = loadname;

    }
}
