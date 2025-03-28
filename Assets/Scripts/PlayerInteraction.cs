using UnityEngine;
using UnityEngine.Events;

public class PlayerInteraction : MonoBehaviour
{
    public static UnityEvent OnInteract = new UnityEvent();

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            OnInteract.Invoke();
        }

    }

}
