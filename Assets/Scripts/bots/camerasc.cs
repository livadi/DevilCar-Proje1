using UnityEngine;
public class camerasc : MonoBehaviour
{
 



    public Vector3 offset;
    private GameObject player;

    public float smoothS = 0.125f;
    void Start()
    {


        player = GameObject.FindGameObjectWithTag("car");


        offset = transform.position - player.transform.position;

    }
  




    void LateUpdate()
    {


    
        Vector3 newPos = player.transform.position + offset;
        transform.position = Vector3.Slerp(transform.position, newPos, smoothS);
    }
}
