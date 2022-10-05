using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenBell : Bell
{
    public override void onBulletEnter()
    {
        onPowerupChange();
    }

    public override void onPowerupChange()
    {
        
        GameObject powerUp = Instantiate(BellManager.instance.greenBellPowerup);
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
