using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseMonster
{

    public int ID;
    public string Name;
    public int TypeMonster;
    public long BaseHp;
    public long BaseDef;
    public long BaseSpeed;
    public int BaseGold;

   
    public BaseMonster SetBaseMonserFromJSON(string jsonString)
    {
        return JsonUtility.FromJson<BaseMonster>(jsonString);
    }
}
