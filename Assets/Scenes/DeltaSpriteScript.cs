using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeltaSpriteScript : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public GameObject character;
    public Sprite jump;
    public Sprite left;
    public Sprite right;
    public Sprite afk;
    public float horizontalMovement;
    public float upspeedMovement;
    public float speed;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKeyUp("space"))
        {
            rb.velocity = new Vector2(rb.velocity.x, upspeedMovement);
        }

       horizontalMovement = Input.GetAxis("Horizontal") * Time.deltaTime * speed*5;
        
    
       rb.velocity = new Vector2(horizontalMovement, rb.velocity.y);

        if (horizontalMovement == 0){
            spriteRenderer.sprite = afk;
        }
        if (horizontalMovement > 0){
            spriteRenderer.sprite = right;
        }
        if (horizontalMovement < 0){
            spriteRenderer.sprite = left;
        }
        if (rb.position.y > -2){ 
            spriteRenderer.sprite = jump;
        }
        Debug.Log(rb.position.y);
    }
}
