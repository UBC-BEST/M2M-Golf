using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerMetreScript : MonoBehaviour
{
    [SerializeField] Rigidbody2D powerMeter;
    private int power = 0;

    // Start is called before the first frame update
    void Start()
    {
        powerMeter.position = new Vector2(-3, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(power);

        if (Input.GetKey(KeyCode.Space)) {
            power++;
        }
        else{
            if(power>0){
                power--;
            }
        }
        
    }
}