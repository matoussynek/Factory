using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Workstation : MonoBehaviour
{
    [Range(.1f, .5f)]
    public float scaleFactor;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Item"))
        {
            collision.gameObject.transform.localScale = new Vector2(1f + scaleFactor, 1f + scaleFactor);
        }
    }
}
