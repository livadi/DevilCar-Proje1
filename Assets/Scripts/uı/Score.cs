using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
  private GameObject peri;
    public TextMeshPro score;
    public static float zo;
   
    void Start()
    {
        peri = GameObject.FindGameObjectWithTag("car");
        score = GetComponent<TextMeshPro>();
    }
    void Update()
    {
        zo = peri.transform.position.z / 100;
       
        score.text = zo.ToString("0");
        
    }
}
