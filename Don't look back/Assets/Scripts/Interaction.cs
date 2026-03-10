using UnityEngine;

public class Interaction : MonoBehaviour
{
    public float interactionDistance;
    public GameObject interactionText;
    public LayerMask interactionLayers;
    public GameObject Toggle;

    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit, interactionDistance, interactionLayers))
        {
            if (hit.collider.gameObject.CompareTag("Interactable"))
                {
                interactionText.SetActive(true);

                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.gameObject.GetComponent<Interactable>().BaseInteract();
                }

            }
            else
            {
                interactionText.SetActive(false);
            }

        }
        else
        {
            interactionText.SetActive(false);
        }
         
    }
}
