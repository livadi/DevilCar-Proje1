using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class carclikvevet : MonoBehaviour
{
 
    public static int unlockcar;

    public Button[] buybutton;
    public GameObject[] buythis;
    private void Start()
    {
      
        unlockcar = PlayerPrefs.GetInt("lockcar");
       


      
            for (int i = 0; i < buybutton.Length; i++)
            {
                if (i > unlockcar)
                    buybutton[i].interactable = false;
            }


        for (int i = 0; i < buythis.Length; i++)
        {
            if (i+1 <=unlockcar)
                buythis[i].SetActive(false);
           
        }

    }

    public void bbutton()
    {
        audiosc.PlaySound("cash");
        unlockcar += 1;
        PlayerPrefs.SetInt("selectedchar", garagemenu.index);
        PlayerPrefs.SetInt("lockcar", unlockcar);
        PlayerPrefs.Save();
        for (int i = 0; i < buythis.Length; i++)
        {
            if (i + 1 <= unlockcar)
                buythis[i].SetActive(false);

        }
    }
    
}
