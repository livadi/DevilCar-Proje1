using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lavamove : MonoBehaviour
{
    float floor = 0.1f;
  
    Renderer rend;
    private void Start()
    {
        rend = GetComponent<Renderer>();
       
    }
    void Update()
    {
        float offset = Time.time * floor;
        Renderer renderer = GetComponent<Renderer>();
            Material mat = renderer.material;

            float emission = Mathf.PingPong(Time.time, 5.0f);
            Color baseColor = Color.yellow;
            Color finalColor = baseColor * Mathf.LinearToGammaSpace(emission);
        rend.material.SetTextureOffset("_MainTex", new Vector2(offset, 0));
        mat.SetColor("_EmissionColor", finalColor);
        
    }
}
