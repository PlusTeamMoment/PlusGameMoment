using UnityEngine;

public class CoreTableInteraction : MonoBehaviour
{
    [SerializeField] PlayerControls playerControls;
    [SerializeField] PlayerMovement playerMovement;
    [SerializeField] GameObject selected;
    [SerializeField] GameObject convertMenu;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        selected.SetActive(true);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (playerControls.InteractionButton == true)
        {
            convertMenu.SetActive(true);
            playerMovement.enabled = false;
        }
        if (convertMenu.activeInHierarchy && playerControls.CloseButton == true)
        {
            playerMovement.enabled = true;
            convertMenu.SetActive(false);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        selected.SetActive(false);
    }
}
