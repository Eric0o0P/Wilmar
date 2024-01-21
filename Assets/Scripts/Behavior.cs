using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Behavior : MonoBehaviour
{
    public GameObject[] eisles;
    public NavMeshAgent creature;

    public GameObject destination;
    // Start is called before the first frame update
    void Start()
    {
        destination = eisles[Random.Range(0, eisles.Length)];
        creature.SetDestination(destination.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        if (creature.remainingDistance == 0)
        {
            destination = eisles[Random.Range(0, eisles.Length)];
            creature.SetDestination(destination.transform.position);
        }
    }
}
