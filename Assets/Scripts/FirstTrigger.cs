using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Collision");
    }
    private void OnTrigerStay(Collider other)
    {
        Debug.Log("Trigger Collision");
    }
    private void OnTrigerExit(Collider other)
    {
        Debug.Log("Trigger Collision");
    }
}

