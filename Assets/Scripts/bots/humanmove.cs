using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class humanmove : MonoBehaviour
{
  
    private float speed = 50f;
   
    public int worth = 10;
    public static int humancunt;
    Animator humanrun;
    void Start()
    {
        humanrun = this.gameObject.GetComponent<Animator>();
        
    }

    void Update()
    {
        humanrun.SetBool("ishuman", true);
      

        transform.Translate(Vector3.forward * speed * Time.deltaTime );
      

    }
    void OnCollisionEnter(Collision cos)
    {
       
      
        if(cos.gameObject.tag=="car")
        {
            audiosc.PlaySound("spy");
           
            Destroy(this.gameObject);
            MoneyUI.Money += worth;
            humancunt += 1;
        }
       
           
    }
    
}
