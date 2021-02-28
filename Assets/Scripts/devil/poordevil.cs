using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poordevil : MonoBehaviour
{

    public Rigidbody rb;
    public int worth = 50;
    public int rageup = 1;
    Animator devil1run;
    private int gorandom;
    public static bool fuelimg;
  

    void Start()
    {
        devil1run = this.gameObject.GetComponent<Animator>();
      
   
        go();
    }

    void go()
    {
        if (this.gameObject.tag == "devil1")
        {
            devil1run.SetBool("ispoord", true);

        }
   
    }
    void OnCollisionEnter(Collision col)
    {
      
        if (col.gameObject.tag == "big")
        {
            sembago();
        }
      
        if (col.gameObject.tag == "car")
        {
           
            gorandom = Random.Range(0, 4);
            devil1run.SetTrigger("isdeath");
                sembago();

                if (gorandom == 1)
                {
                    ragebarUI.devthi += 1;
                    PlayerStats.Devil1 += 1;
                    PlayerPrefs.SetInt("dev1", PlayerStats.Devil1);
                }
        }

    }
    void sembago()
    {
        int randomsound = Random.Range(0, 6);
        if (randomsound == 0)
        {
            audiosc.PlaySound("death3");
            audiosc.PlaySound("death7");
        }
        if (randomsound == 1)
        {
            audiosc.PlaySound("death6");
            audiosc.PlaySound("death8");
        }
        if (randomsound == 2)
        {
            audiosc.PlaySound("death5");
            audiosc.PlaySound("death9");
        }
        if (randomsound == 3)
        {
            audiosc.PlaySound("death4");
            audiosc.PlaySound("death7");
        }
        if (randomsound == 4)
        {
            audiosc.PlaySound("death5");
            audiosc.PlaySound("death10");
        }
        if (randomsound == 5)
        {
            audiosc.PlaySound("death1");
            audiosc.PlaySound("death10");
        }
        gameObject.tag = "Untagged";
            Destroy(gameObject, 1);

            rb.constraints = RigidbodyConstraints.None;
            ragebarUI.rage += rageup;
            newbar.timeleft += 0.8f;
            MoneyUI.Money += worth;
            fuelimg = true;

        PlayerPrefs.SetInt("moni", MoneyUI.Money);
        PlayerPrefs.Save();

    }

}
