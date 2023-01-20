using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProduceSecond : MonoBehaviour , IProduce
{
    public void Consume()
    {
        Produce();
    }

    public void Produce()
    {
        Debug.Log("Second");
    }
}
