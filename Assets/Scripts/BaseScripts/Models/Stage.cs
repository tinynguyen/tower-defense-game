using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage 
{
    private int id;
    private string name;

    public int  Id
    {
        get{ return id; }
        set { id = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public Stage() { }
}
