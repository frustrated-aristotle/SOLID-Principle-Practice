using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProduceFirst : MonoBehaviour, IProduce
{
    public void Consume()
    {
        Produce();
    }

    public void Produce()
    {
        Debug.Log("first");
    }
}
