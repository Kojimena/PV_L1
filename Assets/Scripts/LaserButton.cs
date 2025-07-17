using UnityEngine;

public class LaserButton : MonoBehaviour
{
    //lista de láseres que se activarán al hacer clic
    public GameObject[] lasers;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        // al hacer clic izquierdo, se activa el láser o deactiva
        
        if (Input.GetMouseButtonDown(0))
        {
            // Raycast para detectar el láser
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                // Verifica si el objeto tocado tiene el tag "Laser"
                if (hit.collider.CompareTag("Switch"))
                {
                    // Recorre la lista de láseres y activa/desactiva cada uno
                    foreach (GameObject laser in lasers)
                    {
                        // Verifica si el láser está activo
                        if (laser.activeSelf)
                        {
                            // Si está activo, lo desactiva
                            laser.SetActive(false);
                        }
                        else
                        {
                            // Si no está activo, lo activa
                            laser.SetActive(true);
                        }
                    }
                }
                else
                {
                    Debug.Log("No se tocó  el switch");
                    
                }
            }
        }
        
        
        
        
    }
}
