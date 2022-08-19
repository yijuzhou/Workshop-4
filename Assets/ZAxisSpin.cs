using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZAxisSpin : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.localPosition<=(0.0f, 0.0f, 5.0f) and this.transform.localPosition>=(0.0f, 0.0f, 0.0f)) { 
            this.transform.localPosition += new Vector3(0.0f, 0.0f, 1.0f);
        }
        else if (this.transform.localPosition>=(0.0f, 0.0f, -5.0f) and this.transform.localPosition<=(0.0f, 0.0f, 0.0f)) { 
            this.transform.localPosition += new Vector3(0.0f, 0.0f, -1.0f);
        }
    }
}
