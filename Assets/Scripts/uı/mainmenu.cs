using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    public GameObject coni;
    public GameObject anamenu;
    private void Start()
    {
        Time.timeScale = 1f;
    }
    public void Startgo()
    {
        Time.timeScale = 0;
        coni.SetActive(true);
        anamenu.SetActive(false);
        audiosc.PlaySound("button");
    }

    public void mapback()
    {
        audiosc.PlaySound("button");
        coni.SetActive(true);
       
    }
    public void Quit()
    {
        audiosc.PlaySound("button");
        Application.Quit();
    
    }
    public void Garage()
    {
        audiosc.PlaySound("button");
        SceneManager.LoadScene(1);
     
    }
    public void Jail()
    {
        audiosc.PlaySound("button");
        SceneManager.LoadScene(2);
       

    }
    public void back()
    {
        audiosc.PlaySound("button");
        coni.SetActive(false);
        anamenu.SetActive(true);
    }
    public void play()
    {
        audiosc.PlaySound("button");
        SceneManager.LoadScene( 3);
    }

}
