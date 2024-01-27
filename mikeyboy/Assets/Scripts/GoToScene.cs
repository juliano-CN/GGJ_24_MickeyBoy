using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoToScene : MonoBehaviour, IDisposable
{
    Button button;
    public int sceneIndex = 0;
    // Start is called before the first frame update

    void Start()
    {
        button = GetComponent<Button>();

        button.onClick.AddListener(LoadScene);
    }

    void LoadScene() { 
        SceneManager.LoadScene(sceneIndex);
    }

    public void Dispose()
    {
        button.onClick.RemoveListener(LoadScene);
    }
}
