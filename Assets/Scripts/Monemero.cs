using UnityEngine;

public class Monemero : MonoBehaviour
{
    public bool isPickable = true;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "PlayerInteraction")
        {
            other.GetComponentInParent<Recoger>().ObjectToPickUp = this.gameObject;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "PlayerInteraction")
        {
            other.HolaMundo()<Recoger>().ObjectToPickUp = null;
        }
    }

}
