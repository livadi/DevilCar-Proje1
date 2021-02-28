using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class afterrun : MonoBehaviour
{
  

    public float speed ;
    public int worth = 50;
    public int rageup = 1;
    Animator devil1run;
    Animator devil3run;
    Animator devil4run;
  
    private bool isleft = false;
    private bool isright = false;
    private bool isrun = false;
    private bool iswander = false;
    private int gorandom;
    public Rigidbody rb;
    public static bool devslow;
    public static bool devmov;
    private Transform target;
    void Start()
    {

        target = GameObject.FindGameObjectWithTag("car").transform;
        devil1run = this.gameObject.GetComponent<Animator>();
        devil4run = this.gameObject.GetComponent<Animator>();
        devil3run = this.gameObject.GetComponent<Animator>();
        go();
  
    }
        void Update()
    {
        if (devslow == true)
        {
            speed -= 30;
        }
        
        if (iswander == false)
        {
            StartCoroutine(runaway());
        }
        if (isright == true)
        {
            transform.Rotate(transform.up * Time.deltaTime * speed);
        }
        if (isleft == true)
        {
            transform.Rotate(transform.up * Time.deltaTime * -speed);
        }
        if (isrun == true)
        {
            if (devslow == false && devmov == false)
            {
                transform.position += transform.forward * speed * Time.deltaTime;
            }
            else if (devslow == true && devmov == false)
            {
                transform.position += transform.forward * speed / 2 * Time.deltaTime;
            }
            if (devmov == true && devslow == false)
            {

                transform.position = Vector3.MoveTowards(transform.position, target.position, 170 * Time.deltaTime);
            }
        }
    }
    IEnumerator runaway()
    {
        int rtime = Random.Range(1, 2);
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
    void go()
    {
        if (this.gameObject.tag == "devil1" )
        {            
           devil1run.SetBool("ismoneyrun", true); 
          
        }
        else if (this.gameObject.tag == "devil2")
        {            
           
        }
        else if(this.gameObject.tag == "dombidev"){
            devil3run.SetBool("issosrun", true);
          
        }
        else if (this.gameObject.tag == "mudevil" )
        {
            devil3run.SetBool("ismudevilrunmu", true);
          
        }
    }
  
    void OnCollisionEnter(Collision col)
    {
       
        if (col.gameObject.tag == "big")
        {
            sembago();
           
        }
        if (col.gameObject.tag == "spawn")
        {
            transform.Rotate(transform.up, 120);
        }
       
            if (col.gameObject.tag == "car")
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
                   
                    sembago();
                    ragebarUI.smaldev += 1;
                    if (gorandom == 1)
                    {
                        ragebarUI.devsma += 1;
                        PlayerStats.Devil2 += 1;
                        PlayerPrefs.SetInt("dev2", PlayerStats.Devil2);
                    }
                }
                else if (this.gameObject.tag == "dombidev")
                {
                    devil3run.SetTrigger("isdombideath");
                    ragebarUI.domdev += 1;
                   
                    sembago();

                    if (gorandom == 1)
                    {
                        ragebarUI.devdomb += 1;
                        PlayerStats.Devil3 += 1;
                        PlayerPrefs.SetInt("dev3", PlayerStats.Devil2);
                    }
                }
                else if (this.gameObject.tag == "mudevil")
                {
                    devil4run.SetTrigger("ismudeath");
                   
                    sembago();
                    ragebarUI.mudev += 1;
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
        randommove.fuelimg = true;
        PlayerPrefs.SetInt("moni", MoneyUI.Money);
        PlayerPrefs.Save();

    }
  

}

