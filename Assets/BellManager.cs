using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BellManager : MonoBehaviour
{
    public static BellManager instance = null;

    public GameObject whiteBellPowerup;
    public GameObject greenBellPowerup;
    public GameObject playerClone;
    public int playerGreenPowerupAmount =0;

    //use singleton for bellManager so all objects have access to teh whiteBellPowerup prefab
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
        
    }
}
