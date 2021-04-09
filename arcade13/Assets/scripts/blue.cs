using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blue : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody2D rb;
    public GameObject BlueMeta;
    bool respawn;

    // Start is called before the first frame update
    void Start()
    {
        respawn = true;
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "wall") ;
        {
            Destroy(this.gameObject);
            if (respawn)
            {
                Instantiate(BlueMeta);
                respawn = false;
            }
        }

    }
}