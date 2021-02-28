using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carprice : MonoBehaviour
{
    public   int cprice;

    public void crprice()
    {
        if (cprice < MoneyUI.Money)
        {

            MoneyUI.Money = -cprice;
            GetComponent<carclikvevet>().bbutton();
            PlayerPrefs.SetInt("moni", MoneyUI.Money);
            PlayerPrefs.Save();
        }
    
    }
}
