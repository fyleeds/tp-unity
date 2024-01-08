using UnityEngine;

public class SpawnPrefab : MonoBehaviour
{
    public GameObject cubePrefab;

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.O))
        {
            GameObject cube = Instantiate(cubePrefab, transform.position, Quaternion.identity);

        }
    }
}
