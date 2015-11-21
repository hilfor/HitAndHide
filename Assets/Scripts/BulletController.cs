using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour
{

    public GameObject explodeParticles;
    public float projectileSpeed = 10f;
    public float reloadTime = 1f;


    private Rigidbody localRigidBody;


    void Start()
    {
        localRigidBody = gameObject.GetComponent<Rigidbody>();
        localRigidBody.velocity = transform.forward * projectileSpeed;
        //localRigidBody.AddForce(transform.forward * projectileSpeed, ForceMode.Impulse);

        Destroy(gameObject, 10f);
    }

    void OnCollisionEnter(Collision collision)
    {
        string collisionTag = collision.collider.tag;

        if (collisionTag.Equals("Player") || collisionTag.Equals("Ground"))
        {
            //PhotonNetwork.Instantiate(explodeParticles.name,collision.contacts[0].point,Quaternion.Euler(localRigidBody.velocity,)
        }
    }
}
