
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class levelend : MonoBehaviour
{

    public GameObject sc1;
    public GameObject sc2;
    public GameObject sc3;
    public TextMeshPro x;
    public GameObject peri;
    void Start()
    {
        peri = GameObject.FindGameObjectWithTag("car");
        float xo = Mathf.Round(peri.transform.position.z / 100 *2f);
        
        x.text = xo.ToString("");
        MoneyUI.Money += (int)xo;
        PlayerPrefs.SetInt("moni", MoneyUI.Money);
        PlayerPrefs.SetInt("dev1",PlayerStats.Devil1);
        PlayerPrefs.SetInt("dev2", PlayerStats.Devil2);
        PlayerPrefs.SetInt("dev3", PlayerStats.Devil3);
        PlayerPrefs.SetInt("dev4", PlayerStats.Devil4);
        PlayerPrefs.Save();
    }

 
    
}
