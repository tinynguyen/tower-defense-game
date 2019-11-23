using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySQLTest : MonoBehaviour
{
    void OnGUI()
    {
      if(GUILayout.Button("GetAllStage"))
        {
            /*List<Stage> stages = new MySQLCore().getAllStages();*/
            StageService stageService= new StageServiceImpl();
            List<Stage> stages = stageService.findAll();

            foreach(Stage s in stages)
            {
                Debug.Log(s.Id + "\t" + s.Name);
            }
        }  
    }
}
