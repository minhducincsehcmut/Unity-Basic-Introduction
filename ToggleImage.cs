using UnityEngine;
using UnityEngine.UI;

public class ToggleImage : MonoBehaviour
{
    private Image imageComponent;

    void Start()
    {
        // Get the Image component attached to the GameObject
        imageComponent = GetComponent<Image>();

        if (imageComponent == null)
        {
            Debug.LogError("Image component not found on GameObject: " + gameObject.name);
        }
        else
        {
            Debug.Log("Image component found on GameObject: " + gameObject.name);
        }
    }

    void Update()
    {
        // Toggle the GameObject's active state based on user input (e.g., pressing spacebar)
        if (Input.GetKeyDown(KeyCode.N))
        {
            Debug.Log("Spacebar pressed");

            // Check if the GameObject is currently active
            if (gameObject.activeSelf)
            {
                // If active, disable the GameObject
                gameObject.SetActive(false);
                Debug.Log("GameObject disabled");
            }
            else
            {
                // If disabled, enable the GameObject
                gameObject.SetActive(true);
                Debug.Log("GameObject enabled");
            }
        }
    }

}
