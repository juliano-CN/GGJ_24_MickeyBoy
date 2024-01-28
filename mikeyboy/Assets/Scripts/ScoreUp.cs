using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreUp : MonoBehaviour
{
    [SerializeField]
    inventory inventory;
    [SerializeField]
    Image primeiroPao;
    [SerializeField]
    Image segundoPao;
    [SerializeField]
    Image progressBar;
    [SerializeField]
    Text scoreText;

    bread paoAtual;
    bread proximoPao;
    public float timeAwaiting = 1.5f;

    void Start()
    {
        //StartCoroutine(nameof(AtualizaScore));
    }

    private void OnEnable()
    {
        StartCoroutine(nameof(AtualizaScore));
    }

    IEnumerator AtualizaScore()
    {
        for (int i = 0; i < inventory.breads.Length; i++)
        {
            if (inventory.lastScore >= inventory.breads[i].value)
            {
                paoAtual = inventory.breads[i];
                if (i + 1 < inventory.breads.Length)
                    proximoPao = inventory.breads[i + 1];
            }
        }

        scoreText.text = inventory.lastScore.ToString();
        primeiroPao.sprite = paoAtual.sprite;
        segundoPao.sprite = proximoPao.sprite;
        progressBar.fillAmount = ((float)inventory.lastScore - (float)paoAtual.value) / ((float)proximoPao.value - (float)paoAtual.value);
        
        if(inventory.lastScore < inventory.score)
        {
            yield return new WaitForSeconds(0.05f);
            inventory.lastScore += 1;
            StartCoroutine(nameof(AtualizaScore));
        }
        else
        {
            yield return new WaitForSeconds(timeAwaiting);
            SceneManager.LoadScene(1);
        }
    }
}
