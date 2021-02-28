using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ragebarUI : MonoBehaviour
{
    public TextMeshPro ragebar;
    public static int rage=0;
    public static int smaldev = 0;
    public static int thdev = 0;
    public static int domdev = 0;
    public static int mudev = 0;
    public static int devthi = 0;
    public static int devsma = 0;
    public static int devdomb = 0;
    public static int devmu = 0;
    public GameObject qcomplete;
    void Start()
    {
        transform.GetChild(missionUI.questpoint).gameObject.SetActive(true);
        ragebar = GetComponent<TextMeshPro>();
        rage = 0;
    }

    void Update()
    {
       

        if (missionUI.questpoint == 0)
        {
            ragebar.text = thdev.ToString();
            if (thdev >= 15)
            {
                qcomplete.SetActive(true);
            }
        }
        else if (missionUI.questpoint == 1)
        {
            ragebar.text = thdev.ToString();

            if (thdev >= 30 )
            {
                qcomplete.SetActive(true);
            }
        }
        else if (missionUI.questpoint == 2)
        {
            if (Score.zo >= 500 )
            {
                qcomplete.SetActive(true);
            }
        }
        else if (missionUI.questpoint == 3)
        {
            ragebar.text = humanmove.humancunt.ToString();

            if (humanmove.humancunt >= 5)
            {
                qcomplete.SetActive(true);
            }
        }
        else if (missionUI.questpoint == 4)
        {
            ragebar.text = smaldev.ToString();
            if ( smaldev >= 10)
            {
                qcomplete.SetActive(true);
            }
        }
        else if (missionUI.questpoint == 5)
        {
            ragebar.text = lamp.totem.ToString();
            if (lamp.totem == 10)
            {
                qcomplete.SetActive(true);
            }
        }
        else if (missionUI.questpoint == 6)
        {
            ragebar.text = lamp.totem.ToString();
            if (lamp.totem == 5)
            {
                qcomplete.SetActive(true);
            }
        }
        else if (missionUI.questpoint == 7)
        {
            ragebar.text = devthi.ToString();
            if (ragebarUI.devthi >= 5)
            {
                qcomplete.SetActive(true);
            }
        }
        else if (missionUI.questpoint == 8)
        {
            ragebar.text = domdev.ToString();
            if (domdev >= 15)
            {
                qcomplete.SetActive(true);
            }
        }
        else if (missionUI.questpoint == 9)
        {
            ragebar.text = devdomb.ToString();
            if (devdomb >= 8)
            {
                qcomplete.SetActive(true);
            }
        }
        else if (missionUI.questpoint == 10)
        {
            ragebar.text = lamp.combodev.ToString();
            if (lamp.combodev >= 10)
            {
                qcomplete.SetActive(true);
            }
        }
        else if (missionUI.questpoint == 11)
        {
            ragebar.text = rage.ToString();
            if (rage >= 70)
            {
                qcomplete.SetActive(true);
            }
        }
        else if (missionUI.questpoint == 12)
        {
            ragebar.text = mudev.ToString();
            if (mudev >= 15)
            {
                qcomplete.SetActive(true);
            }
        }
        else if (missionUI.questpoint == 13)
        {
            ragebar.text = mudev.ToString();
            if (mudev >= 20)
            {
                qcomplete.SetActive(true);
            }
        }
        else if (missionUI.questpoint == 14)
        {
           
            if (Score.zo >= 1500)
            {
                qcomplete.SetActive(true);
            }
        }
        else if (missionUI.questpoint == 15)
        {
            ragebar.text = rage.ToString();
            if (rage >= 100)
            {
                qcomplete.SetActive(true);
            }
        }
    }
}