using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public float speed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(0, -1f) * Time.deltaTime * speed);
        if (transform.position.y < -6)
            Destroy(gameObject);
    }
}
