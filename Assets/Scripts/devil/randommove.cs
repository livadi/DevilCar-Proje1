using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
public class randommove : MonoBehaviour
{   
  
    Animator devil1run;

    Animator devil3run;
    Animator devil4run;
    public static bool fuelimg;
    
    public int worth = 50;
    public int rageup = 1;
    public float speed ;
    private bool isleft = false;
    private bool isright = false;
    private bool isrun = false;
    private bool iswander = false;
   public Rigidbody rb;
    private int gorandom;
    public static bool devslow;
    public static bool devmov;
    private Transform target;
    void Start()
    {
        target= GameObject.FindGameObjectWithTag("car").transform;

       
        devil1run = this.gameObject.GetComponent<Animator>();
        devil3run = this.gameObject.GetComponent<Animator>();
        devil4run = this.gameObject.GetComponent<Animator>();
    }
   
    void Update()
    {
        
        if (iswander == false)
        {
            StartCoroutine(runaway());
        }
        if (isright == true)
        {
            transform.Rotate(transform.up * Time.deltaTime * speed*2);
        }
        if (isleft == true)
        {
            transform.Rotate(transform.up * Time.deltaTime * -speed*2);
        }
        if (isrun == true)
        {
            
            if (devslow == false&& devmov == false )
            {
                transform.position += transform.forward * speed * Time.deltaTime;
            }
            else if (devslow == true && devmov == false)
            {
                transform.position += transform.forward * speed/2 * Time.deltaTime;
            }
            if (devmov == true&& devslow == false)
            {
              
                transform.position = Vector3.MoveTowards(transform.position, target.position,170 *Time.deltaTime);
            }
           
        }
    }
    IEnumerator runaway()
    {
        float rtime = Random.Range(0f, 1f);
        int rrun = Random.Range(1, 3);
        int rrotate = Random.Range(1, 2);

        iswander = true;
        yield return new WaitForSeconds(rrun);
        isrun = true;
        if (rrotate == 1)
        {
            isright = true;
            yield return new WaitForSeconds(rtime);
            isright = false;
        }
        if (rrotate == 2)
        {
            isleft = true;
            yield return new WaitForSeconds(rtime);
            isleft = false;
        }
        iswander = false;
    }

    void OnCollisionEnter(Collision col)
    {
   
        if (col.gameObject.tag == "big")
        {
            sembago();
          
        }
        if (col.gameObject.tag == "spawn")
        {
            transform.Rotate(transform.up ,120);
        }
        if (col.gameObject.tag == "car" )
        {
            
            if (col.gameObject.name == "car1")
            {
                gorandom = Random.Range(0, 10);
            }
            if (col.gameObject.name == "car2")
            {
                gorandom = Random.Range(0, 9);
            }
            if (col.gameObject.name == "truck")
            {
                gorandom = Random.Range(0, 6);
            }
            if (col.gameObject.name == "bus")
            {
                gorandom = Random.Range(0, 4);
            }
            if (col.gameObject.name == "bigtruck")
            {
                gorandom = Random.Range(0, 2);
            }
            if (col.gameObject.name == "carw")
            {
                gorandom = Random.Range(0, 9);
            }
            if (col.gameObject.name == "bulls")
            {
                gorandom = Random.Range(0, 10);
            }

            if (this.gameObject.tag == "devil1")
            {
                ragebarUI.thdev += 1;
                devil1run.SetTrigger("isdeath");
                sembago();
               
                if (gorandom == 1)
                {
                    ragebarUI.devthi += 1;
                    PlayerStats.Devil1 += 1;
                    PlayerPrefs.SetInt("dev1", PlayerStats.Devil1);
                }

            }
            else if (this.gameObject.tag == "devil2")
            {
                ragebarUI.smaldev += 1;
                sembago();            
                if (gorandom == 1)
                {
                    ragebarUI.devsma += 1;
                    PlayerStats.Devil2 += 1;
                    PlayerPrefs.SetInt("dev2", PlayerStats.Devil2);
                }
            }
            else if (this.gameObject.tag == "dombidev")
            {
                ragebarUI.domdev += 1;
                devil3run.SetTrigger("isdombideath");
                sembago();              
               
                if (gorandom == 1)
                {
                    ragebarUI.devdomb += 1;
                    PlayerStats.Devil3 += 1;
                    PlayerPrefs.SetInt("dev3", PlayerStats.Devil3);
                }
            }
            else if (this.gameObject.tag == "mudevil")
            {
                ragebarUI.mudev += 1;
                devil4run.SetTrigger("ismudeath");   
                sembago();
               
                if (gorandom == 1)
                {
                    ragebarUI.devmu += 1;
                    PlayerStats.Devil4 += 1;
                    PlayerPrefs.SetInt("dev4", PlayerStats.Devil4);
                }
            }

        }        
       
  
    }

    void sembago()
    {
        int randomsound = Random.Range(0, 7);
        if (randomsound == 0)
        {
            audiosc.PlaySound("death3");
            audiosc.PlaySound("death7");
        }
        if (randomsound == 1)
        {
            audiosc.PlaySound("death6");
            audiosc.PlaySound("death8");
        }
        if (randomsound == 2)
        {
            audiosc.PlaySound("death5");
            audiosc.PlaySound("death9");
        }
        if (randomsound == 3)
        {
            audiosc.PlaySound("death4");
            audiosc.PlaySound("death7");
        }
        if (randomsound == 4)
        {
            audiosc.PlaySound("death5");
            audiosc.PlaySound("death10");
        }
        if (randomsound == 5)
        {
            audiosc.PlaySound("death1");
            audiosc.PlaySound("death10");
        }
        if (randomsound == 6)
        {
            audiosc.PlaySound("death2");
            audiosc.PlaySound("death10");
        }
        gameObject.tag = "Untagged";
        Destroy(gameObject, 1);

        rb.constraints = RigidbodyConstraints.None;
        ragebarUI.rage += rageup;
        newbar.timeleft += 0.5f;
        MoneyUI.Money += worth;
        PlayerPrefs.SetInt("moni", MoneyUI.Money);
        PlayerPrefs.Save();
        fuelimg = true;
   
    }
  

} 
