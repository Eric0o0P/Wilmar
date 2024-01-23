using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Interactor : MonoBehaviour
{
    [SerializeField] private string selectableTag = "Selectable";
    [SerializeField] private int range;
    public Camera cam;
    public int itemCount = 0;
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){   
            var ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            
            if (Physics.Raycast(ray, out hit, range)){
                var selection = hit.transform;
                if (selection.CompareTag(selectableTag))
                {
                    hit.transform.gameObject.SetActive(false);
                    itemCount++;
                }
            }
        }
            
    }
}
