using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse_test : MonoBehaviour
{
    [SerializeField]
    GameObject breadBullet;
    [SerializeField]
    AudioSource disparoAudio;
    [SerializeField]
    Vector2 force;
    [SerializeField]
    points points;
    public int hp;

    Vector2 mousePosition;
    
    void Update()
    {
        //Debug.Log(mousePosition);
        if (Input.GetMouseButtonDown(0))
        {
            mousePosition = Input.mousePosition;
        }

        if (Input.GetMouseButtonUp(0))
        {
            if (Mathf.Abs(Input.mousePosition.x - mousePosition.x) < 10) return;
            disparoAudio.Play();
            if (Input.mousePosition.x > mousePosition.x)
            {
                Rigidbody2D BB = Instantiate(breadBullet, transform.position, Quaternion.identity).GetComponent<Rigidbody2D>();
                BB.AddForce(force);
                BB.GetComponent<bread_Script>().points = points;
                Destroy(BB, 5);
            }
            else
            {
                Rigidbody2D BB = Instantiate(breadBullet, transform.position, Quaternion.identity).GetComponent<Rigidbody2D>();
                BB.AddForce(force * new Vector2(-1, 1));
                BB.GetComponent<bread_Script>().points = points;
                Destroy(BB, 5);
            }
        }
    }
}
