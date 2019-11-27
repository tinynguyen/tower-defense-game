using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;

public class TDMainGameControler : MonoBehaviour
{
    public GameMachine TDGameMachine;

    void Start()
    {

    }

    public void On_Button_Click()
    {
        TDGameMachine.Request_Stage_Data();
    }
}
