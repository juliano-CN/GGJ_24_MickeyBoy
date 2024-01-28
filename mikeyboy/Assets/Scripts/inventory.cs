using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "inventory", menuName = "inventory", order = 1)]
public class inventory : ScriptableObject
{
    public int score;
    public int lastScore;
    public bread[] breads; 
}

[Serializable]
public class bread
{
    public string breadName;
    public Sprite sprite;
    public Texture2D textura;
    public int value;
    public int score;

    public bread(string breadName, int value, Sprite sprite, int score, Texture2D textura)
    {
        this.breadName = breadName;
        this.value = value;
        this.score = score;
        this.sprite = sprite;
        this.textura = textura;
    }
}
