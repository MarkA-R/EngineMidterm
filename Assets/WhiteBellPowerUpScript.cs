using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteBellPowerUpScript : MonoBehaviour
{
    

   

    private void OnCollisionEnter(Collision collision)
    {
       
        if (collision.gameObject.tag.Equals("Player"))
        {
            //if the player comes in contact, use the singleton to change the fire rate
            PlayerFire.instance.setFireTimesPerSecond(PlayerFire.instance.getFiringTimePerSecond() * 2);
            Destroy(gameObject);
        }
    }
}
