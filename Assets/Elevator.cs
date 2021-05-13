using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool elevate = true;

        if (transform.position.y <= 0) {
            elevate = true;
        } else if (transform.position.y >= 70) {
            elevate = false;
        }

        if (elevate) {
            transform.position += new Vector3(0, 5 * Time.deltaTime, 0);
        } else {
            //transform.position -= new Vector3(0, -2 * Time.deltaTime, 0);
            transform.position = new Vector3((float)1.33, (float)1.79, (float)298.26);
        }
    }
}
