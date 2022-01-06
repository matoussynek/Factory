using PathCreation;
using UnityEngine;

public class PathFollower : MonoBehaviour
{
    public PathCreator pathCreator;
    public float speed = 5f;
    float distanceTravelled;
    void Update()
    {
        distanceTravelled += speed * Time.deltaTime;
        if (distanceTravelled >= pathCreator.path.length)
        {
            distanceTravelled = 0;
            GetComponent<Robot>().SetBody(0);
            GetComponent<Robot>().SetColor(Color.white);
        }
        transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled);
    }
}
