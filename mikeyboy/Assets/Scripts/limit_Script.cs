using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class limit_Script : MonoBehaviour
{
    [SerializeField]
    inventory inventory;
    [SerializeField]
    AudioSource perderPontoAudio;
    [SerializeField]
    mouse_test player;
    public Text textHP;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "house")
        {
            player.hp -= 1;
            Destroy(collision.gameObject);
            perderPontoAudio.Play();
            textHP.text = player.hp.ToString();
            if(player.hp <= 0)
            {
                inventory.score += player.GetComponent<points>().score;
                SceneManager.LoadScene("BakedGoodsStore");
            }
        }
    }
}
