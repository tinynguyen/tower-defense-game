using MySql.Data.MySqlClient;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DBUtils 
{
    public static MySqlConnection GetDBConnection()
    {
        string host = "127.0.0.1";
        int port = 3306;
        string database = "tower_defense";
        string username = "tiny";
        string password = "NcDat!08102407";

        return DBMySQLUtils.GetDBConnection(host, port, database, username, password);
    }
}
