using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCloneFire : playerFireObserver
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerFire.instance.subscribe(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
