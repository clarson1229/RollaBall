using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncer : MonoBehaviour
{
    [SerializeField]
    float bouncePower=750;
    private void OnCollisionEnter(Collision collision)
    {
        Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
        PlayerController pc = collision.gameObject.GetComponent<PlayerController>();
        Vector3 bounce = Vector3.Reflect(pc.lastVelocity, collision.contacts[0].normal);
        
        
        Debug.Log("velocity "+ pc.lastVelocity);
        Debug.Log("Bounce" + bounce);
        rb.AddForce(bounce.normalized * bouncePower);
    }
}
