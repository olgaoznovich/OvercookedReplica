using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : BaseCounter
{
    [SerializeField] private KitchenObjectSO kitchenObjectSO;

    public override void Interact(Player player)
    {
        if(!hasKitchenObject())
        {
            //there is no kitchenobject here
            if (player.hasKitchenObject())
            {
                //player is carrying something
                player.getKitchenObject().setKitchenObjectParent(this);
            } else
            {
                //player not carrying anything
            }
        } else
        {
            //there is a kitchenobject here
            if(player.hasKitchenObject()) { 
                // plyaer is carrying something
            } else
            {
                // player is not carrying anything
                getKitchenObject().setKitchenObjectParent(player);
            }
        }
    }
}
