using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Garage : MonoBehaviour
{
    public GameObject[] cargarage;
    public GameObject[] carlight;



    void Start()
    {
        Time.timeScale = 1;
        for (int i = 0; i < cargarage.Length; i++)
        {
            if (i <= carclikvevet.unlockcar)
                cargarage[i].SetActive(true);

        }
        Invoke("lightup", 1);
    }
    void lightup()
    {
        for (int i = 0; i < carlight.Length; i++)
        {
            if (i  <= carclikvevet.unlockcar)
                carlight[i].SetActive(true);

        }
    }
    
}
