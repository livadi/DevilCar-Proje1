using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class carspec : MonoBehaviour
{
    public GameObject gun;
  
    void Start()
    {
        
        Invoke("co", 1);


    }
 
    void Update()
    {

       
    }
    void co()
    {
       
        gun.SetActive(true);
        Invoke("go", 0.2f);
    }
   void go()
    {
        
        gun.SetActive(false);
        Invoke("co", 0.4f);
    }


}



