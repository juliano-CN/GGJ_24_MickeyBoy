using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class limit_Script : MonoBehaviour
{
    [SerializeField]
    inventory inventory;
    [SerializeField]
    AudioSource perderPontoAudio;
    [SerializeField]
    MouseTest player;
    public Text textHP;
    [SerializeField] GameObject UIScore;
    [SerializeField] SpawnHouse spawnLeft, spawnRigth;
    [SerializeField] bool canCount = true;
    [SerializeField] VisualEffect[] emotesFail;

    private void Start()
    {
        if (UIScore == null)
        {
            Debug.LogError("Precisa setar objecto com UI Score .");
        }

        if (spawnLeft == null || spawnRigth == null)
        {
            Debug.LogError("Precisa setar os Objectos de Spawn Left e Right.");
        }

        if (player == null) {
            Debug.LogError("Precisa setar o Player (MouseTest).");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "house" && canCount)
        {
            Destroy(collision.gameObject);

            if (canCount)
            {
                player.hp -= 1;
                perderPontoAudio.Play();
                textHP.text = player.hp.ToString();
                if (collision.transform.position.x > 0)
                    emotesFail[0].Play();
                else
                    emotesFail[1].Play();

                if (player.hp <= 0)
                {
                    inventory.lastScore = inventory.score;
                    inventory.score += player.GetComponent<points>().score;

                    spawnLeft.canSpawn = false;
                    spawnRigth.canSpawn = false;

                    UIScore.SetActive(true);
                    canCount = false;

                    player.canInput = false;
                }
            }                      
        }
    }
}
