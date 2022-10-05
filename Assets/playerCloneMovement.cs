using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCloneMovement : playerMoveObserver
{
    // Start is called before the first frame update
    void Start()
    {
        playerMovement.instance.subscribe(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
