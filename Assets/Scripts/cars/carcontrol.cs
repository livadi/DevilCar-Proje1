using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class carcontrol : MonoBehaviour
{

    Rigidbody rb;
  
    public static bool ragemove;

    private static bool rrotate;
    private static bool lrotate;
    public float leftRight;
    public float hız;
    public float speed;
    bool cargo=false;
    public static bool carspeed;
    void Start()
    {
       
        Invoke("cardo", 2);
        rb = GetComponent<Rigidbody>();
    
    }
  void cardo()
    {
        cargo = true;
    }
void Update()
    {
        if (cargo == true)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime * 5);
            if (transform.position.y > 300)
                transform.position = new Vector3(transform.position.x, 300, transform.position.z);
        }
        var localEuler = transform.localEulerAngles;
        transform.localEulerAngles = localEuler;
        if (localEuler.z > 150)
            localEuler.z = -360 + localEuler.z;
        localEuler.z = Mathf.Clamp(localEuler.z, -1, 1 );
        if (localEuler.y > 180)
            localEuler.y = -360 + localEuler.y;
        localEuler.y = Mathf.Clamp(localEuler.y, -20, 20);
        transform.localEulerAngles = localEuler;
        if (localEuler.x > 180)
            localEuler.x = -360 + localEuler.x;
        localEuler.x = Mathf.Clamp(localEuler.x, -15, 15);
        transform.localEulerAngles = localEuler;

      
   
        if (rrotate)
    {
        transform.Rotate(Vector3.up * Time.deltaTime * leftRight);
        rb.AddForce(hız * hız * Time.deltaTime, 0, 0);
            transform.Rotate(new Vector3(0, 0, 200) * Time.deltaTime);


        }
    if (lrotate)
    {
        transform.Rotate(Vector3.down * Time.deltaTime * leftRight);
        rb.AddForce(-hız * hız * Time.deltaTime, 0, 0);

            transform.Rotate(new Vector3(0, 0, -200) * Time.deltaTime);
         

        }
    
    }

     void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "speed")
        {
            audiosc.PlaySound("boots");
            carspeed = true;
            speed += 30;
            Invoke("stopspeed", 12);
        }
        else if (collision.gameObject.name == "slow")
        {
            audiosc.PlaySound("boots2");
            afterrun.devslow = true;
            randommove.devslow = true;
            Invoke("stopdev", 12);
        }
        else if (collision.gameObject.name == "magnet")
        {
            audiosc.PlaySound("boots3");
            afterrun.devmov = true;
            randommove.devmov = true;
            Invoke("todev", 8);
        }
    }
    void stopspeed()
    {
        carspeed = false;
        speed -= 30;
    }
    void stopdev()
    {
        afterrun.devslow = false;
        randommove.devslow = false;
    }
    void todev()
    {
        afterrun.devmov = false;
        randommove.devmov = false;
    }
    void stopspec()
    {
        ragemove = false;
        transform.GetChild(0).gameObject.SetActive(true);
        transform.GetChild(1).gameObject.SetActive(false);
    }
    public void left()
    {
        rrotate = false;
        lrotate = true;

    }
    public void right()
    {
        lrotate = false;
        rrotate = true;
    }
    public void nobutton()
    {
        lrotate = false;
        rrotate = false;
    }
}



