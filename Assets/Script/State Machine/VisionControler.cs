using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisionControler : StateMachine {

    public Transform eyes;
    public float distanciaValida = 20f;
    Transform target;
    bool check = false;

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Finish").transform;
    }

    private void Update()
    {
        validarDistancia();
    }

    public bool validarDistancia()
    {
        float distanciaActual = Vector3.Distance(target.position, transform.position);

        if (distanciaValida == distanciaActual)
        {
            check = true;
        }



        return Physics.Raycast(eyes.position, eyes.forward, out hit, distanciaValida) && hit.collider.CompareTag("Finish");
    }
}
