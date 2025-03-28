using UnityEngine;

public class AmmoBox : MonoBehaviour
{
    private void OnEnable() { PlayerInteraction.OnInteract.AddListener(RefillAmmo); }
    private void OnDisable() { PlayerInteraction.OnInteract.RemoveListener(RefillAmmo); }

    void RefillAmmo()
    {
        PlayerAmmo playerAmmo = FindObjectOfType<PlayerAmmo>();
        if (playerAmmo != null)
        {
            playerAmmo.ChangeAmmo(10);
            Destroy(gameObject);
        }

    }

}
