using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{//health its the live of the character
    public int health = 5;
    public int level = 1;
    public float speed = 1.2f;
    private Vector3 newPosition;
    // Start is called before the first frame update
    void Start()
    {//uptape health according to the level once
        health = health + level;
        print(health);
        
    }

    // Update is called once per frame
    void Update()
    {

        newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
