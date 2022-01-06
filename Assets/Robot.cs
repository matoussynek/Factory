using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot : MonoBehaviour
{
    public List<Sprite> robotBodies;
    private GameObject body;
    private GameObject head;
    private GameObject hands;

    private void Start()
    {
        body = transform.Find("Body").gameObject;
        head = transform.Find("Head").gameObject;
        hands = transform.Find("Hands").gameObject;
    }
    public void SetBody(int index)
    {
        body.GetComponent<SpriteRenderer>().sprite = robotBodies[index];
    }
    public void SetColor(Color c)
    {
        body.GetComponent<SpriteRenderer>().color = c;
        head.GetComponent<SpriteRenderer>().color = c;
        hands.GetComponent<SpriteRenderer>().color = c;
    }
}
