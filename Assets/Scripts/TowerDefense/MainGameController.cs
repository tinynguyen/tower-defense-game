
using UnityEngine;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.IO;

public class MainGameController : MonoBehaviour
{
    List<BaseMonster> BaseListMonster;

    void Start()
    {
        string jsonBaseMonster = File.ReadAllText(Application.dataPath + "/BaseMonster.json");
        BaseListMonster = new List<BaseMonster>();
        Debug.Log(JArray.Parse(jsonBaseMonster));

        SetBaseBaseListMonserFromJSON(JArray.Parse(jsonBaseMonster));

        Debug.Log(BaseListMonster.Count);
    }

    void SetBaseBaseListMonserFromJSON(JArray jA)
    {
        for (int i = 0; i < jA.Count; i++)
        {
            string jsonString = ((JObject)jA[i]).ToString();
            BaseMonster newMonster = new BaseMonster();
            newMonster = newMonster.SetBaseMonserFromJSON(jsonString);
            Debug.Log(jsonString);
            BaseListMonster.Add(newMonster);
        }
    }
}
