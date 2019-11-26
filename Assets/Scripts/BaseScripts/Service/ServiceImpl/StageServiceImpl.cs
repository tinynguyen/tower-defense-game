using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;

public class StageServiceImpl : StageService
{

    StageRepository stageRepository;

    public StageServiceImpl()
    {
        stageRepository = new StageRepositoryImpl();
    }

    public List<Stage> findAll(MySqlCommand cmd)
    {
        return stageRepository.findAll(cmd);
    }
}
