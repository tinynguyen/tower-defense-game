using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;

public class StageRepositoryImpl : StageRepository
{
    MySQLCore mySQLCore;

    public StageRepositoryImpl()
    {
        mySQLCore = new MySQLCore();
    }
    public List<Stage> findAll()
    {
        string query = "SELECT * FROM stages";
        MySqlConnection conn = mySQLCore.getConnect();
        List<Stage> stages = new List<Stage>();

        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = conn;
        cmd.CommandText = query;
        using (DbDataReader reader = cmd.ExecuteReader())
        {
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Stage stage = new Stage();
                    stage.Id = Convert.ToInt32(reader.GetValue(0));
                    stage.Name = reader.GetString(1);
                    stages.Add(stage);
                }
            }
        }
        return stages;
    }

}
