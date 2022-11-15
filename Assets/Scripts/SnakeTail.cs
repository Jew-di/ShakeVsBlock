using System.Collections.Generic;
using UnityEngine;

public class SnakeTail : MonoBehaviour
{
    public Transform SnakeHead;
    public float CircleDiametr;

    private List<Transform> snakeCircles = new List<Transform>();
    private List<Vector3> positions = new List<Vector3>();

    void Start()
    {
        positions.Add(SnakeHead.position);
        AddCircle();
        AddCircle();
    }
    void Update()
    {
        float distance = ((Vector3)SnakeHead.position - positions[0]).magnitude;

        if (distance > CircleDiametr)
        {
            Vector3 direction = ((Vector3)SnakeHead.position - positions[0].normalized);

            positions.Insert(0, positions[0] + direction * CircleDiametr);
            positions.RemoveAt(positions.Count - 1);

            distance -= CircleDiametr;
        }

        for (int i = 0; i < snakeCircles.Count; i++)
        {
            snakeCircles[i].position = Vector3.Lerp(positions[i + 1], positions[i], distance / CircleDiametr);
        }
    }
    private void AddCircle()
    {
        Transform circle = Instantiate(SnakeHead, positions[positions.Count - 1], Quaternion.identity, transform);
        snakeCircles.Add(circle);
        positions.Add(circle.position);
    }



}
