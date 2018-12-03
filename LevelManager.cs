using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	// Use this for initialization
    public void Demo ()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame ()
    {
        Application.Quit();
    }
}
