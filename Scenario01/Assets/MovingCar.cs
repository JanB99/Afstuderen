using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCar : MonoBehaviour
{
    Vector3 spawnPoint;

    Rigidbody m_RigidBody;
    public float m_speed;

    // Start is called before the first frame update
    void Start()
    {
        spawnPoint = new Vector3(-27f,0.4f,34.6f);
        m_RigidBody = GetComponent<Rigidbody>();
        m_speed = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if(m_RigidBody.position.x < 51)
        {
            m_RigidBody.velocity = transform.forward * m_speed;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "End")
        {
            transform.position = spawnPoint;
        }
    }



}
