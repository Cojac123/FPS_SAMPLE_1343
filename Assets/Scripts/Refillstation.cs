using UnityEngine;

public class Refillstation : MonoBehaviour
{
    private void OnEnable() { PlayerInteraction.OnInteract.AddListener(RefillAmmo); }
    private void OnDisable() { PlayerInteraction.OnInteract.RemoveListener(RefillAmmo); }

    void RefillAmmo()
    {
        //PlayerAmmo playerAmmo = FindObjectOfType<PlayerAmmo>();
        Gun playerGun = FindObjectOfType<Gun>();
        if (playerGun != null)
        {
            //playerAmmo.ChangeAmmo(10)
            playerGun.AddAmmo(10);
            Destroy(gameObject);
        }

    }

}
