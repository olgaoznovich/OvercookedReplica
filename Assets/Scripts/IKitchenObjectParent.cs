using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IKitchenObjectParent
{
    public Transform GetKitchenObjectFollowTransform();

    public void setKitchenObject(KitchenObject kitchenObject);

    public KitchenObject getKitchenObject();

    public void clearKitchenObject();

    public bool hasKitchenObject();
}
