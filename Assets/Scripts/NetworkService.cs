using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;

public class NetworkService : MonoBehaviour
{
    private MySQLCore mySQLCore;
    private StageService stageService;
    private MySqlCommand cmd;
    private MySqlConnection conn;

    void Start()
    {
        stageService = new StageServiceImpl();
        mySQLCore = new MySQLCore();
        cmd = new MySqlCommand();
        conn = mySQLCore.getConnect();
        cmd.Connection = conn;
    }

    public void Request_Stage_Data()
    {
        List<Stage> stages = stageService.findAll(cmd);

        foreach (Stage s in stages)
        {
            Debug.Log(s.Id + "\t" + s.Name);
        }
    }
}
