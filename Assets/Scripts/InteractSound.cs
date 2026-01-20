using UnityEngine;
using FMODUnity;

public class InteractSound : MonoBehaviour, IInteractable
{
    [SerializeField] private EventReference interactSound;
    public void Interact()
    {
        PlaySound();
    }

    private void PlaySound()
    {
        RuntimeManager.PlayOneShot(interactSound);
    }
    
}
