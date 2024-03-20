using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI timer;
    float PowerUpTime = 15; 
    private void Update()
    {
        
        
           PowerUpTime -= Time.deltaTime;

           timer.text = PowerUpTime.ToString();
        
    }

}