using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickToContinue : MonoBehaviour {

    public string scene;
    private bool loadLock; // to ensure that we try to load only 1 scene

    private void Update()
    {
        if (Input.anyKeyDown && !loadLock)
        {
            LoadScene();
        }
    }

    void LoadScene()
    {
        loadLock = true;
        SceneManager.LoadScene(scene);
    }

}
