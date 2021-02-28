using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pause : MonoBehaviour
{
    public static bool GameisPaused = false;
   
    public GameObject PauseMenu;
    public GameObject panel;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
          
            if (GameisPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
   public void Resume()
    {
        audiosc.PlaySound("button");
        panel.SetActive(true);
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
        GameisPaused = false;
      
    }
   public void Pause()
    {
        panel.SetActive(false);
        PauseMenu.SetActive(true);
        Time.timeScale = 0f;
        GameisPaused = true;
        audiosc.PlaySound("button");


    }
    public void Quit()
    {
        Application.Quit();
        audiosc.PlaySound("button");
    }
   public void Menu()
    {
        Time.timeScale = 1f;
        audiosc.PlaySound("button");
        SceneManager.LoadScene(0);
        PlayerPrefs.SetInt("qp", missionUI.questpoint);
    }
    public void REstart()
    {
        audiosc.PlaySound("button");
        SceneManager.LoadScene(3);
        Time.timeScale = 1f;
    }

}
