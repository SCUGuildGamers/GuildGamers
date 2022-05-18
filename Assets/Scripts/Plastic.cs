using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plastic : MonoBehaviour
{
    
    public bool isCopy = false;
    public bool isPickup;
    public Transform position;
    public Plastic[] allplastics;
    SpriteRenderer sprite;


    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        
    }
    public Plastic Spawn(Vector3 position, bool pickupAble)
    {
        // this is where you change the sprite 
        sprite.color = new Color(0, 0, 1, 1);
        if (pickupAble)
        {
            sprite.color = new Color(0,1,0,1);
        }
        GameObject plasticCopy = Instantiate(gameObject);
        Plastic plasticObjCopy = plasticCopy.GetComponent<Plastic>();
        plasticObjCopy.isPickup = pickupAble;
        plasticObjCopy.isCopy = true;
        plasticObjCopy.GetComponent<Transform>().position = position;
        plasticObjCopy.GetComponent<SpriteRenderer>().enabled = true;
       
        
       
        
        return plasticObjCopy;
    }

    public void Destroy()
    {
        Destroy(gameObject);
    }
}
