using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float speed = 1;
    private Rigidbody rb;
    private Animator animator;
    public static bool canJump = true;
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Skill();
    }
    void Move()
    {
        float moveX = -Input.GetAxis("Horizontal");
        float moveZ = -Input.GetAxis("Vertical");
        Debug.Log(moveX);
        Vector3 movement = new Vector3(moveX, 0, moveZ).normalized * speed * Time.deltaTime;
        if (moveZ != 0)
        {
            animator.SetBool("isWalking", true);
        }
        else
        {
            animator.SetBool("isWalking", false);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("jump");
            // movement.y += Time.deltaTime * 20;
        }
        // movement.y -= Time.deltaTime * 20;
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("walk") || animator.GetCurrentAnimatorStateInfo(0).IsName("idle"))
        {
            transform.Translate(movement, Space.Self);
        }


    }

    void Skill()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            canJump = false;
            animator.SetTrigger("earth1");
        }
    }
}
