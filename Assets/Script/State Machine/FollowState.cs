using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowState : VisionControler {

    Transform target;
    float rotationVel = 3.0f;
    float movementVel = 3.0f;
	
	void Start () {
        target = GameObject.FindGameObjectWithTag("Finish").transform;
	}
	
	// Update is called once per frame
	void Update () {
   
	}

    public void Mover()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(target.position - transform.position), rotationVel * Time.deltaTime);
        transform.position += transform.forward * movementVel * Time.deltaTime;
    }
}
