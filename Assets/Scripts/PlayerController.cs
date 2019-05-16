using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

    private Vector3 movement;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        movement = Vector3.zero;
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        if (movement != Vector3.zero)
        {
            rb.MovePosition(transform.position + movement * speed * Time.deltaTime);
            //animator.SetFloat("MoveX", movement.x);
            //animator.SetFloat("MoveY", movement.y);
            //animator.SetBool("Walking", true);
        }
        else
        {
            //animator.SetBool("Walking", false);
        }
    }
}
