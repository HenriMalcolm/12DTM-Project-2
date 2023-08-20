using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private float horizontalInput; // Inupt for moveing
    public float speed = 1.0f; // Speed of player
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");  // Useing A and D
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        if (horizontalInput == 0)
        {
            rb.constraints = RigidbodyConstraints2D.FreezePositionX; // When not moveing this freezes the X position
        }
    }
}
