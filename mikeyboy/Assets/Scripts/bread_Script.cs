using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class bread_Script : MonoBehaviour
{
    public points points;
    [SerializeField] VisualEffect vfx;
    [SerializeField] inventory inventory;

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
            if(transform.position.x > 0)
                points.addPoint(paoAtual.score, 0);
            else
                points.addPoint(paoAtual.score, 1);
            Destroy(collision);
            vfx.enabled = false;
        }
    }
}
