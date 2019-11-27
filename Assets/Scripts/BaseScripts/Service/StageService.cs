using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;

public interface StageService
{
     List<Stage> findAll(MySqlCommand cmd);
}
