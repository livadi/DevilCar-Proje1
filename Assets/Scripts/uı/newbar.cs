using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class newbar : MonoBehaviour
{
    public Slider slider;
    public  float maxtime;
    public GameObject Fueltext;
   
   
   public static float timeleft;

    void Start()
    {
        Fueltext.SetActive(false);
  
        timeleft = maxtime;

        slider = GetComponent<Slider>();
        slider.maxValue = 150;
       
        if (garagemenu.index == 0)
        {
            timeleft = 50;
        }
        else if (garagemenu.index == 1)
        {
            timeleft = 70;
        }
        else if (garagemenu.index == 2)
        {
            timeleft = 90;
        }
        else if (garagemenu.index == 3|| garagemenu.index == 5|| garagemenu.index == 6)
        {
            timeleft = 120;
        }
        else if (garagemenu.index == 4)
        {
            timeleft = 150;
        }
       

    }

   
    void Update()
    {
        
        if (carcontrol.ragemove == false)
        {


            if (timeleft > 0)
            {
                timeleft -= Time.deltaTime;
              

            }
            else
            {
                Fueltext.SetActive(true);
                Time.timeScale = 0f;
                
            }
            
        }
        slider.value = timeleft;
    }
   
    







}