using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
 
    public PlayerMovement Movement;

    public float CollisionInvoke = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "Obstacle")
        {
            Movement.enabled= false;
            FindObjectOfType<Gamemanager>().EndGame(); 
        }        
    }
}
