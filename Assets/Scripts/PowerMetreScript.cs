using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerMetreScript : MonoBehaviour
{
    [SerializeField] Rigidbody2D powerMeter;
    private int power = 0;
    private float power0 = 1.0f;
    public Image fillMeter;
    
    // Start is called before the first frame update
    void Start()
    {
        powerMeter.position = new Vector2(-5, 3);
    }


    // Update is called once per frame
    void Update()1
    {
        Debug.Log(fillMeter.fillAmount);

        if (Input.GetKey(KeyCode.Space)) {
            power++;
        }
        else{
            if(power>0){
                power--;
            }
        }

        if (power <= 300) power0 = 1 - ((float)power / 300);
        
        //Reduce fill amount over 30 seconds
        fillMeter.fillAmount = power0;
    }
}