using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class GAgentVisual : MonoBehaviour
{
    public GAgent thisAgent;

    void Start()
    {
        thisAgent = this.GetComponent<GAgent>();
    }

    void Update()
    {
        
    }
}
