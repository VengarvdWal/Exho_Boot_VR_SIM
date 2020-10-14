using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Path : MonoBehaviour
{

    //De npc volgt floating objects die in de Transform array zijn gezet. de objecten die de npc volgt moet dus bereikbaar zijn voor de boot aanegzien het vector3.movetowards gebruikt. Dus dat betekent dat de doelwit object een float script moet hebben.

    [SerializeField] Transform[] pathCheckPoints;
    [SerializeField] Vector3 targetVector;
    [SerializeField] int pathPoint;
    [SerializeField] float speed;

    // Update is called once per frame
    void Update()
    {
        targetVector = pathCheckPoints[pathPoint].transform.position;

        transform.position = Vector3.MoveTowards(this.transform.position, pathCheckPoints[pathPoint].transform.position, speed);
    }

    /*private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "points")
        {
            pathPoint++;
            Destroy(collision.gameObject);
        }
    }*/

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "points")
        {
            pathPoint++;
            Destroy(other.gameObject);
        }
    }


}