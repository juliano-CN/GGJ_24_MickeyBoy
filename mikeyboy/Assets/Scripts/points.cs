using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;
using UnityEngine.UI;

public class points : MonoBehaviour
{
    public int score = 0;
    public Text textScore;
    [SerializeField] AudioSource pointAudio;
    [SerializeField] VisualEffect[] emotes;

    public void addPoint(int point, int emoteIndex)
    {
        score += point;
        emotes[emoteIndex].Play();
        pointAudio.Play();
        textScore.text = score.ToString();
    }
}
