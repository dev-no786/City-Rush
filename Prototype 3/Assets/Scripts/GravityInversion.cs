using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityInversion : MonoBehaviour
{
    public GameObject objectToAttract;
    
    // Start is called before the first frame update
    void Start()
    {
        // snappingPos = transform.position3.923.923.92

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        objectToAttract.transform.Translate(transform.position + Vector3.down);
    }
}
