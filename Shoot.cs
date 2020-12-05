using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shoot : MonoBehaviour
{
    [SerializeField] Text or;
    [SerializeField] Text vel;
    [SerializeField] Text alt;

    void Start()
    {
        Input.compass.enabled = true;
        Input.location.Start();

    }

    void Update()
    {  
         or.text = Input.compass.trueHeading.ToString();
         vel.text = Input.acceleration.x.ToString();
         alt.text = Input.location.lastData.altitude.ToString();
    }


}
