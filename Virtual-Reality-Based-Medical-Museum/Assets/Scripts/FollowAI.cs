using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowAI : MonoBehaviour
{
    public Transform leader;
    public float followSharpness = 0.1f;

    Vector3 _followOffset;

    void Start()
    {
        // Cache the initial offset at time of load/spawn:
        _followOffset = transform.position - leader.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Apply that offset to get a target position.
        Vector3 targetPosition = leader.position + _followOffset;

        // Keep our y position unchanged.
        targetPosition.y = transform.position.y;

        // Smooth follow.    
        transform.position += (targetPosition - transform.position) * followSharpness;
    }
}
