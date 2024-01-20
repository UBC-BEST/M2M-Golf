using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerMeterOverlay : MonoBehaviour
{
    [SerializeField] Rigidbody2D powerMeter;

    // Start is called before the first frame update
    void Start()
    {
        powerMeter.position = new Vector2(-5, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
