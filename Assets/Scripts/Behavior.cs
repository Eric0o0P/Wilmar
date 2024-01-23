using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.AI;

public class Behavior : MonoBehaviour
{
    public GameObject[] eisles;
    public NavMeshAgent creature;
    public GameObject destination;
    public CreatureFOV creatureFOV;
    public GameObject player;
    
    // Start is called before the first frame update
    void Start()
    {
        destination = eisles[Random.Range(0, eisles.Length)];
        creature.SetDestination(destination.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        if (creatureFOV.canSeePlayer == false)
        {
            creature.speed = 3.5f;
            Roaming();
        }
        else{
            creature.speed = 8f;
            creature.SetDestination(player.transform.position);
        }
    }

    private void Roaming()
    {
         if (creature.remainingDistance == 0)
        {
            destination = eisles[Random.Range(0, eisles.Length)];
            creature.SetDestination(destination.transform.position);
        }
    }
}
