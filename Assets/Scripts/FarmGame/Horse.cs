using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horse : Animal
{
    //private bool isBeingRidden = false;

    //[SerializeField]
   // private float rideOffset = 5;

    private GameObject player;

    public override void Start()
    {
        base.Start();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    public void Update()
    {
        /*
        if (isBeingRidden)
        {
            if (Input.GetButton("Cancel"))
            {
                DismountHorse();
            }
        }
        */
    }

    public override void OnCollisionEnter(Collision other)
    {
        base.OnCollisionEnter(other);
        //if (other.gameObject.CompareTag("Player"))
        //{
        //    MountHorse();
        //}
    }

    /*
    private void MountHorse()
    {
        isBeingRidden = true;
        gameObject.transform.parent = player.transform;
        player.transform.SetPositionAndRotation(transform.position + (Vector3.up * rideOffset), transform.rotation);
    }

    private void DismountHorse()
    {
        isBeingRidden = true;
        gameObject.transform.parent = null;
        player.transform.SetPositionAndRotation(transform.position + (Vector3.forward * rideOffset), Quaternion.identity);
    }
    */
}
