using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SantaBals : MonoBehaviour
{


    public float counter;
    public float dropTime;

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
        }

    }

}
