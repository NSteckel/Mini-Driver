using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 120f;
    [SerializeField] float moveSpeed = 20f;
    [SerializeField] float slowSpeed = 15f;
    [SerializeField] float boostSpeed = 50f;
    [SerializeField] float destroyDelay = 0.25f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * -steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, steerAmount);
        transform.Translate(0, moveAmount, 0);
    }

    // Slow down if hitting any solid objects
    void OnCollisionEnter2D (Collision2D other) 
    {
        moveSpeed = slowSpeed;
    }

    // Speed up when collecting speed boost circle
    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Boost") {
            // Debug.Log("speeeeeeed");
            moveSpeed = boostSpeed;
            Destroy(other.gameObject, destroyDelay);
        }
       
    }
    
}
