using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenObject : MonoBehaviour
{
    [SerializeField] private KitchenObjectSO kitchenObjectSO;
    private IKitchenObjectParent kitchenObjectParent;
    public KitchenObjectSO getKitchenObjectSO()
    { return kitchenObjectSO; }
    public IKitchenObjectParent getKitchenObjectParent()
    { return kitchenObjectParent; }
    public void setKitchenObjectParent(IKitchenObjectParent kitchenObjectParent)
    {
        // deleting from the old counter
        if (this.kitchenObjectParent != null)
        {
            this.kitchenObjectParent.clearKitchenObject();
        }
        // adding to new counter
        this.kitchenObjectParent = kitchenObjectParent;
        if (kitchenObjectParent.hasKitchenObject()) //should never happend, but just in case
            Debug.LogError("counter already has a KitchenObject!");
        kitchenObjectParent.setKitchenObject(this); 
        // update the visual
        transform.parent = kitchenObjectParent.GetKitchenObjectFollowTransform();
        transform.localPosition = Vector3.zero;
    }
}
