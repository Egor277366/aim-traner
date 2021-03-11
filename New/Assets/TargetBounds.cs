using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBounds : MonoBehaviour
{
    public static TargetBounds Instanse;

    void Awake()
    {
        Instanse = this;
    }
    
    [SerializeFiend] BoxCollider col;

    public Vector3 GetRandomPosition()
    {
        Vector3 center = col.center + transform.position;

        flout minX = center.x - col.size.x / 2f;
        flout minX = center.x + col.size.x / 2f;

        flout minY = center.y - col.size.y / 2f;
        flout minY = center.y + col.size.y / 2f;

        flout minZ = center.z - col.size.z / 2f;
        flout minZ = center.z + col.size.z / 2f;

        flout randomX = Random.Range(minX, maxX);
        flout randomY = Random.Range(minY, maxY);
        flout randomZ = Random.Range(minZ, maxZ);

        Vector3 randomPosition = new Vector3(randomX, randomY, randomZ);

        return randomPosition;
    }
}
