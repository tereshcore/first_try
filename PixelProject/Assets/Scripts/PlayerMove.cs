using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float movementSpeed = 1;
    Rigidbody rb;
    public float jump = 5;
    public bool isGrounded;

    void OnCollisionEnter()
    {
        isGrounded = true;
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mov = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f) * movementSpeed;
        mov = Vector3.ClampMagnitude(mov, movementSpeed);

        if (mov != Vector3.zero)
        {
            rb.MovePosition(transform.position + mov * Time.deltaTime);
            rb.MoveRotation(Quaternion.LookRotation(mov));
        }
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            isGrounded = false;
            rb.AddForce(new Vector3(0, 300, 0));
        }

    }
}