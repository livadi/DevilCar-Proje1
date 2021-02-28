using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roadgame : MonoBehaviour
{
    public GameObject[] tilePref;
    private float SpawnZ=-3500;
    private float tileLenght = 5000f;
    private int roadscreen = 2;
    private Transform Playertransform;
    private List<GameObject> Activetiles;
    private float safeLane = 2600;
    private int forro;
    private void Start()
    {
       
        Activetiles = new List<GameObject>();
       
        for (int i = 0; i < roadscreen; i++)
        {
            SpawnTİle();
           
        }
        
    }

  
    private void Update()
    {
        Playertransform = GameObject.FindGameObjectWithTag("car").transform;
        if (Playertransform.position.z-safeLane > (SpawnZ - roadscreen * tileLenght))
        {
            SpawnTİle();
            deleteTile();
        }
     
    }
    private void SpawnTİle(int prefabIndex = -1)
    {

        if (-11 <Score.zo && Score.zo < 10 )
        {
            forro = Random.Range(0, 1);
        }

        else if (11 < Score.zo && Score.zo < 200)
        {
            forro = Random.Range(0, 3);
        }
        else if (201 < Score.zo && Score.zo < 350)
        {
            forro = Random.Range(3, 5);
        }
        else if (351 < Score.zo && Score.zo < 500)
        {
            forro = Random.Range(4, 7);
        }
        else if (501 < Score.zo && Score.zo < 750)
        {
            forro = Random.Range(7, 10);
        }
        else if (751 < Score.zo && Score.zo < 1000)
        {
            forro = Random.Range(9, 12);
        }
        else if (1000 < Score.zo )
        {
            forro = Random.Range(4, 12);
        }

        GameObject go;
      
            go = Instantiate(tilePref[forro]) as GameObject;
            go.transform.SetParent(transform);
            go.transform.position = Vector3.forward * SpawnZ;
            SpawnZ += tileLenght;
            Activetiles.Add(go);
   
    }
    private void deleteTile()
    {

        Destroy(Activetiles[0]);
        Activetiles.RemoveAt(0);

    }
}
