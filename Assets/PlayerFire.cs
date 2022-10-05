using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : Subject
{

   public static PlayerFire instance = null;
    int firingTimePerSecond = 1;//time since firing and firing rate per second
    float timeSinceLastBullet = 0;
    bool canShoot = false;
    public GameObject bulletPrefab;//bullet factory

    private void Awake()
    {
        if(instance == null)//singleton for the playerFire instance so it can be changed by other objects
        {
            instance = this;
        }
    }

    public void setFireTimesPerSecond(int i)
    {
        firingTimePerSecond = i;
    }

    public int getFiringTimePerSecond()
    {
        return firingTimePerSecond;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))//set the canShoot variable
        {
            canShoot = true;
        }
        else
        {
            canShoot = false;
        }

        float timeBetweenFiring = 1f / firingTimePerSecond;
        timeSinceLastBullet += Time.deltaTime;//add to time since firing
        if(timeSinceLastBullet > timeBetweenFiring)
        {
            
            if (canShoot)//if you can shoot, reset the timer and fire
            {
                timeSinceLastBullet = 0;
                shoot(transform);
                triggerEvent();
                
            }
        }
    }

    public void shoot(Transform t)
    {
        //creat enew bullet, move it into position, and then add a foce to it
        GameObject newBullet = Instantiate(bulletPrefab);
        newBullet.transform.position = t.position + Vector3.forward;
        newBullet.GetComponent<Rigidbody>().AddForce(Vector3.forward * 10, ForceMode.Impulse);
    }
}
