using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class bread_Script : MonoBehaviour
{
    public points points;
    [SerializeField] VisualEffect vfx;
    [SerializeField] inventory inventory;
    [SerializeField] AudioSource pointAudio;

    bread paoAtual;

    private void Start()
    {
        foreach(bread pao in inventory.breads)
        {
            if(inventory.score >= pao.value)
            {
                paoAtual = pao;
            }
        }

        vfx.SetTexture("Texture", paoAtual.textura);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "house")
        {
            points.addPoint(paoAtual.score);
            Destroy(collision);
            vfx.enabled = false;
            pointAudio.Play();
        }
    }
}
