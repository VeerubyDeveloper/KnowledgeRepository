using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class JSONWriter : MonoBehaviour
{
    [System.Serializable]

    public class Player
    {
        public string name;
        public int Health;
        public int mana;
    }

    [System.Serializable]

    public class Playerlist
    {
        public Player[] player;
    }

 
    public Player myplayer = new Player();
    public Playerlist myplayerlist = new Playerlist();

    public void outputJSON()
    {
        string stroutput = JsonUtility.ToJson(myplayer);

        File.WriteAllText(Application.dataPath + "/text.txt", stroutput);

        string stroutput2 = JsonUtility.ToJson(myplayerlist);

        File.WriteAllText(Application.dataPath + "/text2.txt", stroutput2);
    }
}
