using UnityEngine;

public class Recoger : MonoBehaviour
{
    public GameObject ObjectToPickUp;
    public GameObject PickedObject;
    public Transform interactionZone;
    void Update()
    {
        if (ObjectToPickUp != null && ObjectToPickUp.GetComponent<Monemero>().isPickable == true && PickedObject == null)
        {
            if(Input.GetKeyDown(KeyCode.F))
            {
                PickedObject = ObjectToPickUp;
                PickedObject.GetComponent<Monemero>().isPickable = false;
                PickedObject.transform.SetParent(interactionZone);
                PickedObject.transform.position = interactionZone.position;
                PickedObject.GetComponent<Rigidbody>().useGravity = false;
                PickedObject.GetComponent <Rigidbody>().isKinematic = true;
            }
        }
        else if(PickedObject != null){
            if (Input.GetKeyDown(KeyCode.F))
            {
                
                PickedObject.GetComponent<Monemero>().isPickable = true;
                PickedObject.transform.SetParent(null); 
                PickedObject.GetComponent<Rigidbody>().useGravity = true;
                PickedObject.GetComponent<Rigidbody>().isKinematic = false;
                PickedObject = null;
            }

        }
    }
}
