using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform centerPoint; 
    public float rotationSpeed;
    private bool isClockwise = true; 

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isClockwise = !isClockwise;
        }

        float direction = isClockwise ? 1f : -1f;
        transform.RotateAround(centerPoint.position, Vector3.forward, direction * rotationSpeed * Time.deltaTime);
    }
}
