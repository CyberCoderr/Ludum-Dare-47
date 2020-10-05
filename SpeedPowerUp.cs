using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPowerUp : MonoBehaviour
{
    public bool speedUp = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            collision.gameObject.GetComponent<CarMovement>().speedUp = true;
            Destroy(gameObject);
        }
    }
}
