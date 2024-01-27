using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse_test : MonoBehaviour
{
    Vector2 mousePosition;
    

    // Update is called once per frame
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
            if(Input.mousePosition.x > mousePosition.x)
            {
                Debug.Log("direita");
            }
            else
            {
                Debug.Log("esquerda");
            }
        }
    }
}
