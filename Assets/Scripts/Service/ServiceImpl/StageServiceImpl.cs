using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageServiceImpl : StageService {

    StageRepository stageRepository;

    public StageServiceImpl()
    {
         stageRepository = new StageRepositoryImpl();
    }

    public List<Stage> findAll()
    {
       return stageRepository.findAll();
    }
}
