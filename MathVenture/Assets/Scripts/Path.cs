using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{ 

    public Transform[] waypoints;

    [SerializeField]
    private float moveSpeed = 1f;

    [HideInInspector]
    public int waypointIndex;

    public bool moveable = false;

    // Start is called before the first frame update
    private void Start()
    {
        waypointIndex = waypoints.Length - 1;
        transform.position = waypoints[waypointIndex].transform.position;
        
    }

    // Update is called once per frame
    public void Update()
    {
        if (moveable)
        {
            Move();
        }

    }


    public void Move()
    {
        if (waypointIndex >= 0)
        {
            if (transform.position == waypoints[waypointIndex].transform.position)
            {
                moveable = false;
            }
            else
            {
                transform.position = Vector2.MoveTowards(transform.position,
                    waypoints[waypointIndex].transform.position,
                    moveSpeed * Time.deltaTime);
            }
        }
    }
}
