using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public Transform F1SP;
    public Rigidbody player;

    void onCollisionEnter(Collider other) {
        player.transform.position = F1SP.position;
    }
}
