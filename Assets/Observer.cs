using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Observer : MonoBehaviour
{
    public abstract void notify();
}

public class Subject : MonoBehaviour
{
    List<Observer> observers = new List<Observer>();

    public void subscribe(Observer o)
    {
        observers.Add(o);
    }
    public void unsubscribe(Observer o)
    {
        if (observers.Contains(o))
        {
            observers.Remove(o);
        }
    }

    public void triggerEvent()
    {
        foreach(Observer o in observers)
        {
            o.notify();
        }
    }
}

public class playerMoveObserver : Observer{
    public override void notify()
    {
        transform.position += playerMovement.instance.vel * playerMovement.instance.speedMultiplier;
    }
}



public class playerFireObserver : Observer
{
    public override void notify()
    {
        PlayerFire.instance.shoot(transform);
    }
}



