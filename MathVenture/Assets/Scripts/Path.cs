using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{ 

    public Transform[] waypoints;

    [SerializeField]
    private float moveSpeed = 1f;

<<<<<<< HEAD

    public int waypointIndex = 0;
=======
    [HideInInspector]
    public int waypointIndex;
>>>>>>> master

    public bool moveable = false;

    // Start is called before the first frame update
    private void Start()
    {
<<<<<<< HEAD
=======
        waypointIndex = waypoints.Length - 1;
>>>>>>> master
        transform.position = waypoints[waypointIndex].transform.position;
        
    }

    // Update is called once per frame
<<<<<<< HEAD
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
=======
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
>>>>>>> master
            }
        }
    }
}
