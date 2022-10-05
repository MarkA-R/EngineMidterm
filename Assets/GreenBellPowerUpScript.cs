using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenBellPowerUpScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag.Equals("Player"))
        {
            //if the player comes in contact, use the singleton to change the fire rate
            //PlayerFire.instance.setFireTimesPerSecond(PlayerFire.instance.getFiringTimePerSecond() * 2);
            BellManager.instance.playerGreenPowerupAmount++;
            GameObject clone = Instantiate(BellManager.instance.playerClone);
            float multiplier = 1;
            if(BellManager.instance.playerGreenPowerupAmount % 2 == 0)
            {
                multiplier = -1;
            }
            clone.transform.position = GameObject.Find("Player").transform.position + (transform.right * 2 * multiplier);
            Destroy(gameObject);
        }
    }


}
