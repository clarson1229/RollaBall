using UnityEngine;

public class forward : MonoBehaviour
{
    [SerializeField]
    float pushPower = 750;
    private void OnCollisionEnter(Collision collision)
    {
        Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
        
        rb.AddForce(10,10,0);
    }
}
