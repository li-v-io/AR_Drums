using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicalObjectCollisionDetection : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Physical object has been touched by " + other.gameObject.name);
    }
}
