using UnityEngine;
using UnityEngine.Events;

public class PlayerAmmo : MonoBehaviour
{
    public static UnityEvent<int> OnAmmoChanged = new UnityEvent<int>();
    private int ammo = 10;

    public void ChangeAmmo(int amount)
    {
        ammo += amount;
        Debug.Log("Ammo added! Current ammo: " + ammo);
        OnAmmoChanged.Invoke(ammo);
    }
    public void AddAmmo(int amount)
    {
        ammo += amount;
        Debug.Log("Ammo added! Current ammo: " + ammo);
        OnAmmoChanged.Invoke(ammo); // Make sure event fires
    }

}
