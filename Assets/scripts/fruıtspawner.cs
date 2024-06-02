using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class fruıtspawner : MonoBehaviour
{
    [SerializeField] GameObject[] friutPrefab;
    [SerializeField] float secondSpawn = 0.5f;
    [SerializeField] float minTras;
    [SerializeField] float maxTras;
    void Start()
    {
       
        
            StartCoroutine(friutSpawn());
        

        IEnumerator friutSpawn()
        {
            while (true)
            {
                var wanted = Random.Range(minTras, maxTras);
                var position = new Vector3(wanted, transform.position.y);
                GameObject gameObject = Instantiate(friutPrefab[Random.Range(0, friutPrefab.Length)],
                    position, Quaternion.identity);
                yield return new WaitForSeconds(secondSpawn);
                Destroy(gameObject, 5f);
            }
        }
    }

    
}
