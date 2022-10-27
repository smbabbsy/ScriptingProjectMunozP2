using UnityEngine;
using System.Collections;

public class IFStatements : MonoBehaviour
{
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

            coffeeTemperature -= Time.deltaTime * 5f;
    }

    void TemperatureTest ()
    {
        if (coffeeTemperature > hotLimitTemperature)
        {
            print("Coffee is too hot.");
        }
        else if (coffeeTemperature < coldLimitTemperature)
        {
            print("Coffee is too cold.");
        }
        else
        {
            print("Coffee is just right.");
        }
    }
}
