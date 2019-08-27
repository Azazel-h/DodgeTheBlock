using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public float gravityScale = 50f;

    void Start ()
    {
        GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad / gravityScale;
    }

    void Update()
    {
        if (transform.position.y <= -8f)
        {
            Destroy(gameObject);
        }
    }
}
