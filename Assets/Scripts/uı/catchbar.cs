using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class catchbar : MonoBehaviour
{
    public TextMeshPro jaildev;
    public GameObject qcomplete;
    void Start()
    {
        transform.GetChild(missionUI.questpoint).gameObject.SetActive(true);
        jaildev = GetComponent<TextMeshPro>();
    }

    void Update()
    {
        if (missionUI.questpoint == 0)
        {
            if ( Score.zo >= 300)
            {
                qcomplete.SetActive(true);
            }
        }
        else if (missionUI.questpoint == 1)
        {
            jaildev.text = lamp.rockobject.ToString();
            if ( lamp.rockobject >= 5)
            {              
                qcomplete.SetActive(true);
          }
        }
        else if (missionUI.questpoint == 2)
        {
            jaildev.text = ragebarUI.devthi.ToString();
            if ( ragebarUI.devthi >= 5)
            {
                qcomplete.SetActive(true);
            }
        }
        else if (missionUI.questpoint == 3)
        {
            jaildev.text = lamp.rockobject.ToString();
            if (lamp.rockobject >= 10 )
            {
                qcomplete.SetActive(true);
            }
        }
        else if (missionUI.questpoint == 4)
        {
            jaildev.text = lamp.dooropen.ToString();
            if (lamp.dooropen >= 3 )
            {
                qcomplete.SetActive(true);
            }
        }
        else if (missionUI.questpoint == 5)
        {
            jaildev.text = lamp.combodev.ToString();
            if (lamp.combodev == 5)
            {
                qcomplete.SetActive(true);
            }
        }
        else if (missionUI.questpoint == 6)
        {
            jaildev.text = lamp.totem.ToString();
            if (ragebarUI.domdev==10)
            {
                qcomplete.SetActive(true);
            }
        }
        else if (missionUI.questpoint == 7)
        {
            jaildev.text = ragebarUI.devsma.ToString();
            if (ragebarUI.devsma >= 5)
            {
                qcomplete.SetActive(true);
            }
        }
        else if (missionUI.questpoint == 8)
        {
            jaildev.text = ragebarUI.rage.ToString();
            if (ragebarUI.rage>=50)
            {
                qcomplete.SetActive(true);
            }
        }
        if (missionUI.questpoint == 9)
        {
            if (Score.zo >= 1000)
            {
                qcomplete.SetActive(true);
            }
        }
        if (missionUI.questpoint == 10)
        {
            if (lamp.dooropen>=5)
            {
                qcomplete.SetActive(true);
            }
        }
        if (missionUI.questpoint == 11)
        {
            if (lamp.rockobject >= 20)
            {
                qcomplete.SetActive(true);
            }
        }
        if (missionUI.questpoint == 12)
        {
            if (humanmove.humancunt >= 10)
            {
                qcomplete.SetActive(true);
            }
        }
        if (missionUI.questpoint == 13)
        {
            if (ragebarUI.devmu >= 5)
            {
                qcomplete.SetActive(true);
            }
        }
        if (missionUI.questpoint == 14)
        {
            if (lamp.totem >= 15)
            {
                qcomplete.SetActive(true);
            }
        }
        if (missionUI.questpoint == 15)
        {
            if (ragebarUI.devmu >= 30)
            {
                qcomplete.SetActive(true);
            }
        }
    }

}
