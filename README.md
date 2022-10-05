# EngineMidterm

The singleton was done by having the playerFire and playerMovement scripts save an instance of themselves within their code. on Awake() they initialize the instnace to a copy of themselves for other classes to access. This is mainly done in order to allow other classes to access data (such as the fire rate, or the players velocity).

The observer pattern was implemented by having an observer and Subject classes that observers and subjects would inherit from. The Subject class has a list of observers for it to notify, and each Observer has a notify() abstract function that is called whenever the Subject's triggerEvent() function is called. This is used with the player clones so that they move and fire along with the player in an event-based way.
