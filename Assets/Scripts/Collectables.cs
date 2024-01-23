using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : MonoBehaviour
{
    public GameObject[] collectables;
    public GameObject[] selected;
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 2; i++)
        {
            int r = UnityEngine.Random.Range(0, collectables.Length);
            selected[i] = collectables[r];
            selected[i].SetActive(true);
        }
    }
}
