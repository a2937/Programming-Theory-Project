using System;
using UnityEngine;

public class PlayerController : LivingGameEntity
{

    private Camera gameCamera;

    public override void Start()
    {
        base.Start();
        gameCamera = Camera.main;
        gameCamera.transform.SetParent(transform);
    }

    // Update is called once per frame
    public void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Move(new Vector2(horizontalInput, verticalInput));
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
    }

    public override void Move(Vector2 direction)
    {
        base.Move(direction);
        animator.SetFloat("Speed", direction.y);
    }
}
