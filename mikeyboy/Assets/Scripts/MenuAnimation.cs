using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuAnimation : MonoBehaviour
{
    [SerializeField]
    Sprite[] sprites;
    [SerializeField]
    Image image;

    void Start()
    {
        StartCoroutine(nameof(Anim));
    }

    IEnumerator Anim()
    {
        while (true)
        {
            foreach(Sprite _sprite in sprites)
            {
                image.sprite = _sprite;
                yield return new WaitForSeconds(0.06f);
            }
        }
    }
}
