using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour
{

    public GameObject explodeParticles;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        string collisionTag = collision.collider.tag;
        Rigidbody localRigidBody = GetComponent<Rigidbody>();

        if (collisionTag.Equals("Player") || collisionTag.Equals("Ground"))
        {
            //PhotonNetwork.Instantiate(explodeParticles.name,collision.contacts[0].point,Quaternion.Euler(localRigidBody.velocity,)
        }
    }
}
