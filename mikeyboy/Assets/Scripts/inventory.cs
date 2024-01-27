using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "inventory", menuName = "inventory", order = 1)]
public class inventory : ScriptableObject
{
    public int score;
    public bread[] breads; 
}

[Serializable]
public class bread
{
    public string breadName;
    public int value;
    public bool owner;

    public bread(string breadName, int value,bool owner)
    {
        this.breadName = breadName;
        this.value = value;
        this.owner = owner;
    }
}
