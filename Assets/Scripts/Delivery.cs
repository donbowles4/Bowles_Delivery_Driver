using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] float fltDestroyDelay = 0.5f;
    bool blnHasPackage;
    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("I hit something!");
    }
    void OnTriggerEnter2D(Collider2D other)
     {
        if (other.tag == "Package" && !blnHasPackage)
        {
        Debug.Log("Package picked up.");
        blnHasPackage = true; 
        Destroy(other.gameObject, fltDestroyDelay);
        }
        if (other.tag == "Customer" && blnHasPackage)
        {
        Debug.Log("Package Delivered.");
        blnHasPackage = false;
        }
    }
}
