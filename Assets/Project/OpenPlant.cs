using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPlant : MonoBehaviour
{
    public GameObject plantdestroyerhere; 

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void OnTriggerStay()
    {
        if (Input.GetKey(KeyCode.E))
            Destroy(plantdestroyerhere);
    }
}