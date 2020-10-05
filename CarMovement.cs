using UnityEngine;
using System.Collections;

public class CarMovement : MonoBehaviour {

    [SerializeField]private float speed;    

    private Rigidbody2D rb;

    public float speedModifyer;

    public bool speedUp = false;

    // Use this for initialization
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D> ();
    }

    private void Update()
    {
        if(speedUp == true)
        {
            StartCoroutine(SpeedUp());
        }
    }


    void FixedUpdate()
    {        
        if (Input.GetKey("a"))
        {
        	Vector2 movement = new Vector2 (-speedModifyer, 0f);
        	rb.AddForce (movement * speed);
        }
        if (Input.GetKey("d"))
        {
        	Vector2 movement = new Vector2 (speedModifyer, 0f);
        	rb.AddForce (movement * speed);
        }
    }

    IEnumerator SpeedUp()
    {
        speedUp = false;
        speedModifyer = 0.08f;
        yield return new WaitForSeconds(10f);
        speedModifyer = 0.05f;
        
    }
}
