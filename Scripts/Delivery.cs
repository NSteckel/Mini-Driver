 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32 (1,1,1,1);
    [SerializeField] Color32 noPackageColor = new Color32 (1,1,0,1);
    [SerializeField] float destroyDelay = 0.25f;

    bool hasPackage;

    SpriteRenderer spriteRenderer;

    void Start() 
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    
    void OnTriggerEnter2D(Collider2D other) 
    {
        // package pickup, tint spprite color, destroy package
        if (other.tag == "Package" && !hasPackage) 
        {
            Debug.Log("Package picked up!");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, destroyDelay);
        }

        // package delivery, untint spprite color, destroy customer
        if (other.tag == "Customer" && hasPackage) 
        {
            Debug.Log("Package delivered.");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
            Destroy(other.gameObject, destroyDelay);
        }
    }
}
