using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class SantaTimer : MonoBehaviour
{

    float currentTime = 0f;
    float startingTime = 10f;

    public Text countDownText;
    
    
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        countDownText.color = Color.green;

        currentTime -= 1 * Time.deltaTime;
        countDownText.text = currentTime.ToString ("0");

        if(currentTime <= 0)
        {
            currentTime = 0;
        }
        if (currentTime <= 6)
        {
            countDownText.color = Color.yellow;
        }

        if (currentTime <= 3)
        {
            countDownText.color = Color.red;
        }

        if (currentTime == 0)
        {
            
            countDownText.text = "L + Ratio";
            
        }

    }
}


