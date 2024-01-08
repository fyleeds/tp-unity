using UnityEngine;

public class SpawnPrefab : MonoBehaviour
{
    public GameObject[] Asteroids;
    public float Maxtime = 1f; // Max time interval between spawns
    public float maxY, minY;
    private float currentTime; // To track the time since the last spawn

    void Update()
    {
        // Increment the timer
        currentTime += Time.deltaTime;

        // Check if it's time to spawn a new asteroid
        if (currentTime >= Maxtime)
        {
            SpawnAsteroids();

            // Reset the timer and set the next spawn interval
            currentTime = 0;
            Maxtime = Random.Range(0, 0.8f); // Increase these values to reduce spawn rate
        }
    }

    public void SpawnAsteroids()
    {
        Instantiate(Asteroids[Random.Range(0, Asteroids.Length)], new Vector3(transform.position.x, Random.Range(minY, maxY), 0), Quaternion.identity);
    }
}
