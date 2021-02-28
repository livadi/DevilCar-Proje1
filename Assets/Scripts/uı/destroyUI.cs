using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyUI : MonoBehaviour
{
    public GameObject img;
    public GameObject cicu;
    public GameObject magnet;
    public GameObject speed;
    public GameObject slow;
    public GameObject fal;
    void Update()
    {
        if (randommove.fuelimg == true)
        {
            img.SetActive(true);
            cicu.SetActive(true);
            Invoke("horro", 0.2f);
        }
        if (lamp.falrock == true)
        {
            fal.SetActive( true);
            Invoke("heprock", 0.8f);
        }
        

        if (randommove.devmov == true || afterrun.devmov)
        {
            magnet.SetActive(true);
        }
        else
        {

            magnet.SetActive(false);
        }
        if (randommove.devslow == true || afterrun.devslow)
        {
            slow.SetActive(true);
        }
        else
        {
            slow.SetActive(false);   
        }
        if (carcontrol.carspeed==true)
        {
            speed.SetActive(true);
        }
        else
        {
            speed.SetActive(false);
        }
    }
    void horro()
    {
        randommove.fuelimg = false;
        img.SetActive(false);
        cicu.SetActive(false);
    }
    void heprock()
    {
        fal.SetActive(false);
        lamp.falrock =false;
    }

    
}
