using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemperatureCheck : MonoBehaviour
{

    [SerializeField] private float currentPorridgeTemperature = 85.0f;

    private float hotLimitTemperature = 70.0f;
    private float coldLimitTemperature = 40.0f;

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TemperatureTest();
        }

        currentPorridgeTemperature -= Time.deltaTime * 5f;
    }

    private void TemperatureTest()
    {
        if (currentPorridgeTemperature > hotLimitTemperature)
        {
            Debug.Log("The porridge is too hot. " + (int)currentPorridgeTemperature + "°C");
        }
        else if (currentPorridgeTemperature < coldLimitTemperature)
        {
            Debug.Log("The porridge is too cold. " + (int)currentPorridgeTemperature + "°C");
        }
        else
        {
            Debug.Log("The porridge is just right! " + (int)currentPorridgeTemperature + "°C");
        }
    }
}
