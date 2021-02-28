
using UnityEngine;
using TMPro;


public class MoneyUI : MonoBehaviour
{
    public static int Money;
    public TextMeshPro moneyText;
  
    void Start()
    {
      
        Money = PlayerPrefs.GetInt("moni");


        moneyText = GetComponent<TextMeshPro>();
       
    }

    void Update()
    {
    
        moneyText.text = Money.ToString();
    }
}
