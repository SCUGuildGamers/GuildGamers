using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlasticHitbox : MonoBehaviour, iCollisionHandler
{
    // Start is called before the first frame update

    private Health playerHealth;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void CollisionEnter(string colliderName, GameObject other)
    {
        if (colliderName == "Plastic")
        {
            playerHealth.reduceHealth(5);
        }
    }
}