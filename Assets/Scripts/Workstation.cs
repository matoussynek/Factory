using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Workstation : MonoBehaviour
{
    public int setBody = 0;
    public bool coloring = false;
    public Color color;
    public GameObject actionKey;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Item"))
        {
            if (setBody != 0)
                collision.gameObject.GetComponent<Robot>().SetBody(setBody);
            if (coloring && color != null)
                collision.gameObject.GetComponent<Robot>().SetColor(color);
        }
        if (collision.CompareTag("Player"))
        {
            actionKey.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            actionKey.SetActive(false);
        }
    }
}
