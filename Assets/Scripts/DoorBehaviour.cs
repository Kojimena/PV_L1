using UnityEngine;

public class DoorBehaviour : MonoBehaviour
{
    
    [SerializeField] private Material openDoorMaterial; // Material de la puerta abierta
    [SerializeField] private MeshRenderer doorRenderer; // Renderer de la puerta


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && PlayerInventory.hasKey)
        {
            if (doorRenderer != null && openDoorMaterial != null)
            {
                doorRenderer.material = openDoorMaterial;
            }
        }
        else if (other.CompareTag("Player"))
        {
            Debug.Log("You need a key to open this door.");
        }
    }
}
