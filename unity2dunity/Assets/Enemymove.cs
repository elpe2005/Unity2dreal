using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enem : MonoBehaviour
{
    public GameObject enemy;
    public float speed;
    private float distance;
    void Start()
    {
    
    }
    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, enemy.transform.position);
        Vector2 direction = enemy.transform.position - transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;


        if(distance < 7){
            transform.position = Vector2.MoveTowards(this.transform.position, enemy.transform.position, speed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(Vector3.forward * angle);
        }
    }
}
