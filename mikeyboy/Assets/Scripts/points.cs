using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class points : MonoBehaviour
{
    public int score = 0;
    public Text textScore;

    public void addPoint(int point)
    {
        score += point;
        textScore.text = score.ToString();
    }
}
