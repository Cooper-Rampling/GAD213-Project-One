using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 3;
    private int index = 0;
    public List<Transform> swoop = new List<Transform>();
    //public List<Transform> dive = new List<Transform>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 destination = swoop[index].transform.position;
        transform.position = Vector2.MoveTowards(transform.position, destination, speed * Time.deltaTime);
        

        float distance = Vector2.Distance(transform.position, destination);
        if (distance <= 0.05)
        {
            if (index < swoop.Count - 1)
            {
                index++;
            }
            else
            {
                index = 0;
                //destination = 
                transform.position = swoop[0].transform.position;

            }

        }
    }
}
