using System.Collections;
using UnityEngine;

public class MaterialFlashHandler : MonoBehaviour
{
    [SerializeField] private Material whiteMaterial;
    [SerializeField] private MeshRenderer meshRenderer;

    private Material originalMaterial;
    private Coroutine coroutine;

    private void Awake()
    {
        originalMaterial = meshRenderer.material;        
    }

    public void Flash(float durationInSeconds)
    {
        if(coroutine != null)
        {
            StopCoroutine(coroutine);
        }
        coroutine = StartCoroutine(PlayFlash(durationInSeconds));
    }

    private IEnumerator PlayFlash(float durationInSeconds)
    {
        meshRenderer.material = whiteMaterial;
        yield return new WaitForSeconds(durationInSeconds);
        meshRenderer.material = originalMaterial;
    }
}