using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighter : Player
{
   public float superiorityDice = 1;

   protected void ActionServe()
   {
      var use = superiorityDice;
   }
}
