using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseController : MonoBehaviour {

    public GameObject canvas;
    public UnityStandardAssets.Characters.FirstPerson.FirstPersonController fpsController;
    public PlayerActionController playerActionController;
    public GameObject eventSystem;

    public bool isPaused = false;

    float initTimeScale = 1;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log("P Pressed");
            isPaused = !isPaused;

            if (isPaused)
            {
                Pause();
            }
            else
            {
                UnPause();
            }
        }
	}

    void Pause()
    {
        canvas.SetActive(true);
        fpsController.enabled = false;
        playerActionController.enabled = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Time.timeScale = 0;
        eventSystem.SetActive(true);
        
        
    }

    void UnPause()
    {
        canvas.SetActive(false);
        fpsController.enabled = true;
        playerActionController.enabled = true;
        Time.timeScale = initTimeScale;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        eventSystem.SetActive(false);
    }

    public void ResetTimeScale()
    {
        Time.timeScale = initTimeScale;
    }
}
