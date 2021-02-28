using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class player : MonoBehaviour
{
    Animator planim;
    public GameObject mis;
    public GameObject anamis;
    void Start()
    {
        Time.timeScale = 0;
        planim = gameObject.GetComponent<Animator>();

    }

  
    public void getcar()
    {
        audiosc.PlaySound("paper");
        Time.timeScale = 0.05f;
        planim.SetBool("iscath",true);
        mis.SetActive(false);
        Invoke("deddo",0.1f);
        Destroy(gameObject,0.5f);
    }
 
     
      void deddo()
    {
        audiosc.PlaySound("rockstart1");
        anamis.SetActive(true);
        Time.timeScale = 1;
       
    }  
         

        
    
}
