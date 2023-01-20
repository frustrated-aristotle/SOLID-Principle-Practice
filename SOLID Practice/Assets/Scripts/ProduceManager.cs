using System;
using UnityEngine;

public class ProduceManager : MonoBehaviour
{

   //We have different producers in the game.
   //All of them produce differently.
   public GameObject[] producers;
   
   private IProduce _produce;

   private void Start()
   {
      InvokeRepeating(nameof(Produce), 0, 1);
   }

   private void Produce()
   {
      foreach (GameObject producer in producers)
      {
         _produce = producer.GetComponent<IProduce>();
         _produce.Consume();
      }
   }
   
}
