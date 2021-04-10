using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{  
    public float Speed = 5.0f;
    void Start()
    {
        
    }

    
    void Update()
    {
        
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        var direction = new Vector3 (x,0,z);     

        transform.position += direction * Time.deltaTime * Speed;
        Debug.Log(x);
    }
}
