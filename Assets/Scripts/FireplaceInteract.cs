using UnityEngine;
using FMODUnity;

public class FireplaceInteract : MonoBehaviour, IInteractable
{
    [Header(("Ognisko"))]
    [SerializeField] private GameObject ogniskoPrefab;

    [Header("Dzwięki")]
    [SerializeField] private EventReference fireplaceStart;
    [SerializeField] private EventReference fireplaceStop;

    [Header("Stan")]
    [SerializeField] private bool isActive = true;


    public void Interact() // Turn On or Off the fire
    {
        isActive = isActive;
        if (ogniskoPrefab != null)
        {
            ogniskoPrefab.SetActive(isActive);
            PlayInteractSound();
        }

    }

    private void PlayInteractSound() //Play audio if I turn On fire or Turn it off
    {
        if (isActive)
        {
            RuntimeManager.PlayOneShot(fireplaceStart);
        }
        else
        {
            RuntimeManager.PlayOneShot(fireplaceStop);
        }
    }
}
