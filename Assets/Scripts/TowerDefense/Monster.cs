using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : BaseMonster
{

    //public long Hp;
    public long Hp;
    public long CurHP;

    // Start is called before the first frame update
    void Start()
    {
        CurHP = Hp;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
