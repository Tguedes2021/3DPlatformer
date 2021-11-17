using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    int count = 1;
    int goal = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 10; i++)
        {
            Debug.Log(i);
        }


        while (count <= goal)
        {
            Debug.Log(count);
            count++;
        }

    }
}
