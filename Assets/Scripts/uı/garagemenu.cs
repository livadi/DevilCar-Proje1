
using UnityEngine;
using UnityEngine.SceneManagement;

public class garagemenu : MonoBehaviour
{
  
    private GameObject[] charlist;
    public static int index;
    private void Start()
    {
      
        PlayerPrefs.GetInt("selectedchar");
       
        index = PlayerPrefs.GetInt("selectedchar");
        charlist = new GameObject[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            charlist[i] = transform.GetChild(i).gameObject;
            
        }   
        foreach(GameObject go in charlist)
        {
            go.SetActive(false);
        }
        if (charlist[index])
        {
            charlist[index].SetActive(true);
        }
       
    }
 
    public void left()
    {
        charlist[index].SetActive(false);
        index--;
        if (index < 0)
            index = charlist.Length-1;
        charlist[index].SetActive(true);
        audiosc.PlaySound("button");
    }
    public void right()
    {
        charlist[index].SetActive(false);
        index++;
        if (index ==charlist.Length)
            index = 0;
        charlist[index].SetActive(true);
        audiosc.PlaySound("button");
    }
    public void confirm()
    {
        PlayerPrefs.SetInt("selectedchar", index);
        SceneManager.LoadScene("level1");
        PlayerPrefs.Save();
        audiosc.PlaySound("button");
    }
    
 
    
}
