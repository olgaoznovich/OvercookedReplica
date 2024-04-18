using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuttingCounter : BaseCounter
{
    [SerializeField] private CuttingRecipeSO[] cuttingRecipeSOArray;
    public override void Interact(Player player)
    {
        if (!hasKitchenObject())
        {
            //there is no kitchenobject here
            if (player.hasKitchenObject())
            {
                //player is carrying something
                if(hasRecipeWithInput(player.getKitchenObject().getKitchenObjectSO()))
                    player.getKitchenObject().setKitchenObjectParent(this);
            }
            else
            {
                //player not carrying anything
            }
        }
        else
        {
            //there is a kitchenobject here
            if (player.hasKitchenObject())
            {
                // plyaer is carrying something
            }
            else
            {
                // player is not carrying anything
                getKitchenObject().setKitchenObjectParent(player);
            }
        }
    }

    public override void InteractAlternate(Player player)
    {
        if (hasKitchenObject() && hasRecipeWithInput(getKitchenObject().getKitchenObjectSO()))
        {
            KitchenObjectSO outputKitchenObjectSO = getOutputForInput(getKitchenObject().getKitchenObjectSO()); 
            getKitchenObject().DestroySelf();
            KitchenObject.SpawnKitchenObject(outputKitchenObjectSO, this);
        }
    }

    private bool hasRecipeWithInput(KitchenObjectSO inputKitchenObjectSO)
    {
        foreach (CuttingRecipeSO cuttingRecipeSO in cuttingRecipeSOArray)
        {
            if (cuttingRecipeSO.input == inputKitchenObjectSO)
            {
                return true;
            }
        }
        return false;
    }
    private KitchenObjectSO getOutputForInput(KitchenObjectSO inputKitchenObjectSO)
    {
        foreach(CuttingRecipeSO cuttingRecipeSO in cuttingRecipeSOArray)
        {
            if(cuttingRecipeSO.input == inputKitchenObjectSO)
            {
                return cuttingRecipeSO.output;
            }
        }
        return null;
    }
}
