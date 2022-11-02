using UnityEngine;
using System.Collections;


public class ForLoop: MonoBehaviour
{
    int numEnemies = 3;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numEnemies; i++)
        {
            Debug.Log("Creating enemy number: " + i);
        }
    }
}