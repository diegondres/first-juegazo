using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basics : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    // Se reproduce antes que el start
    void Awoke(){

    }

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D.gravityScale = 0.5f;
        rigidbody2D.simulated = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
