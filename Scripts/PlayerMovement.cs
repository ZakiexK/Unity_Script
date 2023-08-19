using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody Rigb;
    
    public float ForwardForce = 1000f;
    public float SideForce = 750f;
    public float BackwardForce = 1100f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        Rigb.AddForce(0,0,ForwardForce * Time.deltaTime);

        if (Input.GetKey("d")  )
        {
            Rigb.AddForce(SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        
        if (Input.GetKey("a"))
        {
            Rigb.AddForce(-SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        
        if (Input.GetKey("s")) 
        {
            Rigb.AddForce(0, 0, -BackwardForce * Time.deltaTime);
        }

        if (Rigb.position.y < -2)
        {
            FindObjectOfType<Gamemanager>().EndGame(); 
        }

    }
}
