using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCollision : MonoBehaviour
{
   public Transform fire;
   void Start()
    {
        fire.GetComponent<ParticleSystem>();
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.name == "Player")
        { UnityEngine.Debug.Log("12345"); }
    }
}

/*
 {
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        { UnityEngine.Debug.Log("12345"); }
     }
}
*/