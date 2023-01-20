using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProduceThird : MonoBehaviour, IProduce
{
    public void Consume()
    {
        Produce();
    }

    public void Produce()
    {
        Debug.Log("Third");
    }
}
