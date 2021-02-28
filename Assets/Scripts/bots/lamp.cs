using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lamp : MonoBehaviour
{

    public static int rockobject;
    public static int dooropen;
    public static int totem ;
    public static int combodev ;
    public static bool falrock;
    private void OnCollisionEnter(Collision col)
    {
         if (col.gameObject.tag == "car")
        {
         
            if (this.gameObject.name == "door")
            {
                audiosc.PlaySound("rock4");
                dooropen += 1;
            }
           else if (this.gameObject.name == "totem")
            {
              
                audiosc.PlaySound("rock3");
                audiosc.PlaySound("totem");
                totem += 1;
               
            }
            else if (gameObject.name == "rock"|| this.gameObject.name == "rock 1"|| this.gameObject.name == "de")
            {
                int ro = Random.Range(0, 3);
                if (ro == 0)
                {
                    audiosc.PlaySound("rock2");
                    audiosc.PlaySound("rock3");
                }
                if (ro == 1)
                {
                    audiosc.PlaySound("rock1");
                    audiosc.PlaySound("rock4");
                }
                if (ro == 2)
                {
                    audiosc.PlaySound("rock1");
                    audiosc.PlaySound("rock2");
                }
                falrock = true;
                  rockobject += 1;
                this.gameObject.name = "ci";
            }
           

           else if (gameObject.name == "spy")
        {
                audiosc.PlaySound("human");
                combodev += 1;
                Destroy(gameObject);
        }
          

        }

       
    }
}