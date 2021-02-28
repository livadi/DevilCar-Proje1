using UnityEngine;
using System.Collections;


public class PlayerStats : MonoBehaviour {

    
  

    public static int Devil1;
    public static int Devil2;
    public static int Devil3;
    public static int Devil4;

    void Start()
    {
        
       
        Devil1 = PlayerPrefs.GetInt("dev1");
        Devil2 = PlayerPrefs.GetInt("dev2");
        Devil3 = PlayerPrefs.GetInt("dev3");
        Devil4 = PlayerPrefs.GetInt("dev4");


    }

    

}
