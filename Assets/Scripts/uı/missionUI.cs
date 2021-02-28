using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missionUI : MonoBehaviour
{
    public static int questpoint;

   public GameObject[] obj;
   


    void Start()
    {
       
        PlayerPrefs.GetInt("qp");

      
    }
  
   public void qcombutton()
    {
        if (questpoint == 0 && ragebarUI.rage >= 15 && Score.zo >= 300)
        {
            questpoint = 1;
            PlayerPrefs.SetInt("qp", questpoint);
            MoneyUI.Money += 50;
          
           
        }
        else if (questpoint == 1 && ragebarUI.rage >= 30 && lamp.rockobject >= 5)
        {
            questpoint = 2;
            PlayerPrefs.SetInt("qp", questpoint);
            MoneyUI.Money += 75;
        }
        else if (questpoint == 2 && Score.zo >= 500 && ragebarUI.devthi >= 5)
        {
            questpoint = 3;
            PlayerPrefs.SetInt("qp", questpoint);
            MoneyUI.Money += 125;
        }
        else if (questpoint == 3&& lamp.rockobject >= 10 && humanmove.humancunt >= 5)
        {
            questpoint = 4;
            PlayerPrefs.SetInt("qp", questpoint);
            MoneyUI.Money += 150;
        }
        else if (questpoint == 4 && lamp.dooropen >= 3 && ragebarUI.smaldev >= 10)
        {
            questpoint = 5;
            PlayerPrefs.SetInt("qp", questpoint);
            MoneyUI.Money += 200;
        }
        else if (questpoint == 5 && lamp.combodev==5 && ragebarUI.devsma == 10)
        {
            questpoint = 6;
            PlayerPrefs.SetInt("qp", questpoint);
            MoneyUI.Money += 200;
        }
        else if (questpoint == 6 && lamp.totem == 5 && ragebarUI.domdev==10)
        {
            questpoint = 7;
            PlayerPrefs.SetInt("qp", questpoint);
            MoneyUI.Money += 200;
        }
        else if (questpoint == 7 && ragebarUI.devthi >= 5 && ragebarUI.devsma >= 5)
        {
            questpoint = 8;
            PlayerPrefs.SetInt("qp", questpoint);
            MoneyUI.Money += 200;
        }
        else if (questpoint == 8 && ragebarUI.domdev >= 15 && ragebarUI.rage >= 50)
        {
            questpoint = 9;
            PlayerPrefs.SetInt("qp", questpoint);
            MoneyUI.Money += 250;
        }
        else if (questpoint == 9 && Score.zo >= 1000 && ragebarUI.devdomb >= 8)
        {
            questpoint = 10;
            PlayerPrefs.SetInt("qp", questpoint);
            MoneyUI.Money += 350;
        }
        else if (questpoint == 10 && lamp.combodev >= 10 && lamp.dooropen >= 5 )
        {
            questpoint = 11;
            PlayerPrefs.SetInt("qp", questpoint);
            MoneyUI.Money += 500;
        }
        else if (questpoint == 11 && lamp.rockobject >= 20 && ragebarUI.rage >= 70)
        {
            questpoint = 12;
            PlayerPrefs.SetInt("qp", questpoint);
            MoneyUI.Money += 750;
        }
        else if (questpoint == 12 && humanmove.humancunt >= 10 && ragebarUI.mudev >= 15)
        {
            questpoint = 13;
            PlayerPrefs.SetInt("qp", questpoint);
            MoneyUI.Money += 1000;
        }
        else if (questpoint == 13 && ragebarUI.mudev >= 20 && ragebarUI.devmu >= 5)
        {
            questpoint = 14;
            PlayerPrefs.SetInt("qp", questpoint);
            MoneyUI.Money += 1200;
        }
        else if (questpoint == 14 && Score.zo >= 1500 && lamp.totem >= 15)
        {
            questpoint = 15;
            PlayerPrefs.SetInt("qp", questpoint);
            MoneyUI.Money += 1500;
        }
        else if (questpoint == 15 && ragebarUI.rage>=100 && ragebarUI.devmu >= 30)
        {
            questpoint = 1;
            PlayerPrefs.SetInt("qp", questpoint);
            MoneyUI.Money += 2000;
        }
        PlayerPrefs.SetInt("moni", MoneyUI.Money);
        PlayerPrefs.Save();
    }

}
