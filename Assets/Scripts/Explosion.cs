using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public float force, radius, modifier;
    public GameObject explosionFX;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyExplosion", 0.5f);
        Instantiate(explosionFX, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        Rigidbody rigidbody = other.GetComponent<Rigidbody>();
        if (rigidbody != null)
        {
            rigidbody.AddExplosionForce(force, transform.position, radius, modifier,ForceMode.VelocityChange);
        }
    }

    void DestroyExplosion()
    {
        Destroy(gameObject);
    }
}
