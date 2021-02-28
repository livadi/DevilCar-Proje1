using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class papermission : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.GetChild(missionUI.questpoint).gameObject.SetActive(true);
       
    }

}
