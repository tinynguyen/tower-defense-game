using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMachine : MonoBehaviour
{
    public NetworkService TDNetworkService;
    //public MainGameControler TDMainGameController;

    void Start()
    {
        
    }

    public void Request_Stage_Data()
    {
        TDNetworkService.Request_Stage_Data();
    }

}
