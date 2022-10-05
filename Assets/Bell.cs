using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Bell : MonoBehaviour
{
    //bell is a subject for its child to observe
    //abstract methods for bells to inherit from
    public abstract void onBulletEnter();
    public abstract void onPowerupChange();

    private void OnCollisionEnter(Collision collision)
    {
        //if there is a collision, trigger the event
        if (collision.gameObject.tag.Equals("Bullet"))
        {
            onBulletEnter();
            
            
        }
    }
}
