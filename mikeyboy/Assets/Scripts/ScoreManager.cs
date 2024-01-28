using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField]
    inventory inventory;
    [SerializeField]
    Image primeiroPao;
    [SerializeField]
    Image segundoPao;
    [SerializeField]
    Image progressBar;

    bread paoAtual;
    bread proximoPao;

    void Start()
    {
        for (int i = 0; i < inventory.breads.Length; i++)
        {
            if (inventory.score >= inventory.breads[i].value)
            {
                paoAtual = inventory.breads[i];
                if(i + 1 < inventory.breads.Length)
                    proximoPao = inventory.breads[i + 1];
            }
        }

        primeiroPao.sprite = paoAtual.sprite;
        segundoPao.sprite = proximoPao.sprite;
        progressBar.fillAmount = ((float)inventory.score - (float)paoAtual.value) / ((float)proximoPao.value - (float)paoAtual.value);
    }
}
