using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class propellerController : MonoBehaviour
{
    private float speed = 5000.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, speed * Time.fixedDeltaTime, Space.Self);
    }
}
