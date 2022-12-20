using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SantaMover : MonoBehaviour
{

    public GameObject santaIcon;
    public float santaSpeed;
    public float leftEdge;
    public float rightEdge;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (santaIcon.transform.position.x < leftEdge || santaIcon.transform.position.x > rightEdge)
        {
            santaSpeed = -santaSpeed;
        }

        santaIcon.transform.position = new Vector2(santaIcon.transform.position.x + santaSpeed * Time.deltaTime, santaIcon.transform.position.y);



    }
}
