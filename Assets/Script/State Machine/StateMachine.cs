using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour {

    public MonoBehaviour AlertState;
    public MonoBehaviour FollowState;
    public MonoBehaviour StartState;

    private MonoBehaviour ActualState;

    // Use this for initialization
    void Start () {
        ActivateState(StartState);
		
	}
	
	// Update is called once per frame
	void Update () {
        bool validarDistancia = VisionControler.validarDistancia;

        if (V)
        {
            FollowState.Mover
            
        }
	}

    public void ActivateState(MonoBehaviour NewState)
    {
        if (ActualState != null) ActualState.enabled = false;
        ActualState = NewState;
        ActualState.enabled = true;
    }
}
