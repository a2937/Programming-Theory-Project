using System;
using UnityEngine;

public abstract class LivingGameEntity : MonoBehaviour
{
    [SerializeField]
    [Min(1)]
    protected float MovementSpeed = 1;

    [SerializeField]
    [Min(1)]
    protected float JumpHeight = 1;

    protected Rigidbody myRigidbody;

    protected AudioSource soundSource;

    protected Animator animator;

    protected bool isGrounded = false;


    [SerializeField]
    protected float RotateSpeed = 30;
    public virtual void Start()
    {
        soundSource = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
        myRigidbody = GetComponent<Rigidbody>();
    }

    public virtual void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    public virtual void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }

    public virtual void Jump()
    {
        if (isGrounded)
        {
            myRigidbody.AddForce(Vector3.up * JumpHeight, ForceMode.Impulse);
        }
    }

    public virtual void Move(Vector2 direction)
    {
        transform.Rotate(direction.x * Time.deltaTime * RotateSpeed * Vector3.up);
        myRigidbody.AddForce(direction.y * MovementSpeed * transform.forward, ForceMode.Impulse);
    }

    public virtual void Reset()
    {
        if (GetComponent<AudioSource>() == null)
        {
            AudioSource audioSource = gameObject.AddComponent<AudioSource>();
            audioSource.playOnAwake = false;
        }
        if (GetComponent<Animator>() == null)
        {
            gameObject.AddComponent<Animator>();
        }
        if (GetComponent<Rigidbody>() == null)
        {
            gameObject.AddComponent<Rigidbody>();
        }
    }
}

