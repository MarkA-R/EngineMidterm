using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteBell : Bell
{
    int timesHit = 0;
    public override void onBulletEnter()
    {
        timesHit++;
        if(timesHit < 3)//must get hit 3 times before changing powerups
        {
            return;
        }
        onPowerupChange();
    }

    public override void onPowerupChange()
    {
       GameObject powerUp =  Instantiate(BellManager.instance.whiteBellPowerup);
        powerUp.transform.position = transform.position;
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
