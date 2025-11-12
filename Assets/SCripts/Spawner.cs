using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
    public GameObject cactus_prefab;
    float timer;
    private void FixedUpdate()
    {
        timer += Time.deltaTime;

        if (timer > 3.5f)
        {
            Instantiate(cactus_prefab, transform.position, Quaternion.Euler(0, 90, 0));
            timer = 0;
        }
    }
}
