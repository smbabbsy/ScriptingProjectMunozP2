using UnityEngine;
using System.Collections;

public class DoWhileLoop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        bool shouldContinue = false;
        do
        {
            print("Hello World");

        } while (shouldContinue == true);
    }
}
