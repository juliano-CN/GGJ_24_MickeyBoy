using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class limit_Script : MonoBehaviour
{
    [SerializeField]
    mouse_test player;
    public Text textHP;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "house")
        {
            player.hp -= 1;
            Destroy(collision.gameObject);
            textHP.text = player.hp.ToString();
            //if(player.hp <= 0)

        }
    }
}
