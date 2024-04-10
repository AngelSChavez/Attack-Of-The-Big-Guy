using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class DebugUI : MonoBehaviour
{

    public Rigidbody rb;
    float playerSpeed;
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        rb = GameObject.Find("NormalPlayer").GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Player Speed: " + playerSpeed;
    }

    private void FixedUpdate()
    {
        playerSpeed = rb.velocity.magnitude;
    }

}
