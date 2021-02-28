using UnityEngine.UI;
using UnityEngine;

public class jailspawn : MonoBehaviour
{


    public GameObject[] devil;
    public GameObject spawnh;
    int rdevil;
    public GameObject but;
    public GameObject tex;
    private randommove rr;

    private GameObject go;
     void Awake()
    {
        Time.timeScale = 1;
        PlayerPrefs.GetInt("dev1");
        PlayerPrefs.GetInt("dev2");
        PlayerPrefs.GetInt("dev3");
        PlayerPrefs.GetInt("dev4");
        PlayerPrefs.GetInt("moni");
    }
    void Start()
    {
      

        for (int i = 0; i < PlayerPrefs.GetInt("dev1"); i++)
        {

         Instantiate(devil[0], spawnh.transform.position, Quaternion.identity);

        }
        for (int i = 0; i < PlayerPrefs.GetInt("dev2"); i++)
        {
           Instantiate(devil[1], spawnh.transform.position, Quaternion.identity);

        }
        for (int i = 0; i < PlayerPrefs.GetInt("dev3"); i++)
        {
             Instantiate(devil[2], spawnh.transform.position, Quaternion.identity);

        }
        for (int i = 0; i < PlayerPrefs.GetInt("dev4"); i++)
        {
            Instantiate(devil[3], spawnh.transform.position, Quaternion.identity) ;

        }

    }
 
    public void destroy()
    {
        but.SetActive(false);
        tex.SetActive(true);

        audiosc.PlaySound("cash");
        MoneyUI.Money += PlayerPrefs.GetInt("dev4") * 40;
        MoneyUI.Money += PlayerPrefs.GetInt("dev3") * 30;
        MoneyUI.Money += PlayerPrefs.GetInt("dev2") * 20;
        MoneyUI.Money += PlayerPrefs.GetInt("dev1") * 10;
    
        PlayerPrefs.DeleteKey("dev1");
        PlayerPrefs.DeleteKey("dev2");
        PlayerPrefs.DeleteKey("dev3");
        PlayerPrefs.DeleteKey("dev4");

        PlayerPrefs.SetInt("moni", MoneyUI.Money);

        PlayerPrefs.Save();

    }
    
        
    




}




