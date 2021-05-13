using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool elevate = true;

        if (transform.position.y <= 53) {
            elevate = true;
        } else if (transform.position.y >= 120) {
            elevate = false;
        }

        if (elevate) {
            transform.position += new Vector3(0, 5 * Time.deltaTime, 0);
        } else {
            //transform.position -= new Vector3(0, -2 * Time.deltaTime, 0);
            transform.position = new Vector3((float)93.16, (float)52.71, (float)298.26);
        }
    }
}
