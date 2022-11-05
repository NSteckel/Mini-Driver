using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkControl : MonoBehaviour
{
     [SerializeField] float moveSpeed = 15f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveAmountHor = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        transform.Translate(moveAmountHor, 0, 0);

        float moveAmountVert = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(0, moveAmountVert, 0);
    }
}
