using UnityEngine;

public class PanelMovement : MonoBehaviour
{
    // Target to look at
    public Transform target;

    void Update()
    {
        // Translate the panel
        //TranslatePanel();

        // Rotate the panel
       // RotatePanel();

        // Make the panel look at the target
        LookAtTarget();
    }

    // Function to translate the panel
    void TranslatePanel()
    {
        // Example translation code
        float translationSpeed = 10.0f;
        transform.Translate(Vector3.right * translationSpeed * Time.deltaTime);
    }

    // Function to rotate the panel
    void RotatePanel()
    {
        // Example rotation code
        float rotationSpeed = 50f;
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }

    // Function to make the panel look at the target
    void LookAtTarget()
    {
        // Make the panel look at the target
        if (target != null)
        {
            transform.LookAt(target);
        }
    }
}
