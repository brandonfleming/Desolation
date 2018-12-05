using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.SceneManagement;

public class PauseScreen : MonoBehaviour {

    public GameObject PauseUI;
    public GameObject Player;

	// Use this for initialization
	void Start () {
        PauseUI.SetActive(false);

    }

    // Update is called once per frame
    void Update () {
		
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
	}

    
   void Pause ()
    {
        Time.timeScale = 0f;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        Player.GetComponent<FirstPersonController>().enabled = false;
        PauseUI.SetActive(true);
        Debug.Log("IsPaused");
    }

    public void Resume ()
    {
        Time.timeScale = 1f;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        Player.GetComponent<FirstPersonController>().enabled = true;
        PauseUI.SetActive(false);
        Debug.Log("IsResuming");
    }

    public void MainMenu ()
    {
        SceneManager.LoadScene(0);
    }

}
