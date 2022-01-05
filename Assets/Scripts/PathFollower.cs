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
            transform.localScale = new Vector2(1f, 1f);
        }
        transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled);
    }
}
