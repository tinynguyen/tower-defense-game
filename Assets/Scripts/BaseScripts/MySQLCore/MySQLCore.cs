using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using MySql.Data.MySqlClient;
using System.Data.Common;

public class MySQLCore 
{

    public MySqlConnection getConnect()
    {
        MySqlConnection conn = DBUtils.GetDBConnection();
        if (conn.State != ConnectionState.Open)
        {
            conn.Open();
        }
        return conn;
    }

    

}
