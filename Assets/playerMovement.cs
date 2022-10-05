using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : Subject
{

    public static playerMovement instance = null;
    public Vector3 vel = Vector3.zero;
    public float speedMultiplier = 0.05f;
    public void Awake()
    {
        if(instance != null)
        {
            return;
        }
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 1;
        
        vel = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            vel.z = speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            vel.z = -speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            vel.x = -speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            vel.x = speed;
        }

        transform.position += vel*speedMultiplier;
        triggerEvent();
    }
}
