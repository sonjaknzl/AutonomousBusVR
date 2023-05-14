using UnityEngine;

public class LazyLoad : MonoBehaviour
{
    public LayerMask layerMask;
    
    private void OnBecameVisible()
    {
        gameObject.layer = 0;
    }
    
    private void OnBecameInvisible()
    {
        gameObject.layer = layerMask.value;
    }
}
