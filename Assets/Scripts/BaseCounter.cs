using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCounter : MonoBehaviour, IKitchenObjectParent
{
    [SerializeField] private Transform counterTopPoint;
    private KitchenObject kitchenObject; //makes the counter know if it has something on top of it

    public virtual void Interact(Player player)
    {
        Debug.LogError("BaseCounter.Interact");
    }
    public virtual void InteractAlternate(Player player)
    {
        Debug.LogError("BaseCounter.InteractAlternate");
    }

    public Transform GetKitchenObjectFollowTransform()
    { return counterTopPoint; }
    public void setKitchenObject(KitchenObject kitchenObject)
    { this.kitchenObject = kitchenObject; }
    public KitchenObject getKitchenObject()
    { return this.kitchenObject; }
    public void clearKitchenObject()
    { kitchenObject = null; }
    public bool hasKitchenObject()
    { return kitchenObject != null; }
}
