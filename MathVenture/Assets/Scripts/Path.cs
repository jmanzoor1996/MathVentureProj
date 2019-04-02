using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{ 

    public Transform[] waypoints;

    [SerializeField]
    private float moveSpeed = 1f;


    public int waypointIndex = 0;

    public bool moveable = false;

    // Start is called before the first frame update
    private void Start()
    {
        transform.position = waypoints[waypointIndex].transform.position;
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (moveable)
            Move();
    }


    private void Move()
    {
        if (waypointIndex <= waypoints.Length - 1)
        {
            transform.position = Vector2.MoveTowards(transform.position,
                waypoints[waypointIndex].transform.position,
                moveSpeed * Time.deltaTime);

            if (transform.position == waypoints[waypoints.Length - waypointIndex].transform.position)
            {
                waypointIndex -= 1;
            }
        }
    }
}
