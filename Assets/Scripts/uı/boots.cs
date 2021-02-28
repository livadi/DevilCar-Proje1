using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boots : MonoBehaviour
{
    private GameObject[] charlist;
    private int index;
    void Start()
    {
         index = Random.Range(0, 3);
        charlist = new GameObject[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            charlist[i] = transform.GetChild(i).gameObject;

        }
        foreach (GameObject go in charlist)
        {
            go.SetActive(false);
        }
        if (charlist[index])
        {
            charlist[index].SetActive(true);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "car")
        {
            charlist[index].SetActive(false);
        }
    }
    private void Update()
    {
        transform.Rotate(transform.up * Time.deltaTime * 70);
    }
}
