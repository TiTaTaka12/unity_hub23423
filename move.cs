using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class move : MonoBehaviour
{
    public Rigidbody2D rb;
    public LayerMask gnd;
    public Collider2D coll;
    public int speed;
    public int jump;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        coll = gameObject.GetComponent<PolygonCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2 (speed, rb.velocity.y);
        if(Input.GetKey(KeyCode.Space) && coll.IsTouchingLayers(gnd)){
            rb.velocity = new Vector2 (rb.velocity.x, jump);
        }
    }
void OnTriggerEnter2D(Collider2D other){
    if(other.gameObject.tag == "Finish"){
SceneManager.LoadScene(SceneManager.GetActiveScene().name);


    }
    }
}









