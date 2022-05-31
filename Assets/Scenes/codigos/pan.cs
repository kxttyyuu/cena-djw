using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pan : MonoBehaviour
{
    public Vector3 m;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D))
        {
            m.x = 0f;
            m.y = 0f;
            m.z = 0.5f;

            transform.Translate(m);
        }

        if(Input.GetKey(KeyCode.W))
        {
            m.x = -0.5f;
            m.y = 0f;
            m.z = 0f;

            transform.Translate(m);
        }

        if(Input.GetKey(KeyCode.S))
        {
            m.x = 0.5f;
            m.y = 0f;
            m.z = 0f;

            transform.Translate(m);
        }

        if(Input.GetKey(KeyCode.A))
        {
            m.x = 0f;
            m.y = 0f;
            m.z = -0.5f;

            transform.Translate(m);
        }
    }
}
