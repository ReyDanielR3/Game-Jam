using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SantaBals : MonoBehaviour
{


    public float counter;
    public float dropTime;
    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        counter += Time.deltaTime;
        if (counter > dropTime)
        {
            counter = 0;
            Instantiate(ball, new Vector3(this.transform.position.x, this.transform.position.y - 1f, this.transform.position.z), Quaternion.identity);   
        }

    }

}
