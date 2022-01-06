using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class ProductLine : MonoBehaviour
{
    private PathCreator path;
    private LineRenderer line;
    public int sampleRate = 100;
    void Start()
    {
        List<Vector3> points = new List<Vector3>();
        path = GetComponent<PathCreator>();
        line = GetComponent<LineRenderer>();
        float segmentSize = path.path.length / (float)sampleRate;
        for (int i = 0; i < sampleRate; i++)
        {
            points.Add(path.path.GetPointAtDistance(i * segmentSize));
        }
        line.SetVertexCount(points.Count);
        line.SetPositions(points.ToArray());
    }
}
