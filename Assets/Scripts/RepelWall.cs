using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepelWall : MonoBehaviour
{

    //public Collider cd;
    //public GameObject player;
    //public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        //cd = GetComponent<Collider>();

        //rb = player.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject)
        {
            other.GetComponent<Rigidbody>().AddForce(0, 10, 50, ForceMode.Impulse);
        }
    }

}
