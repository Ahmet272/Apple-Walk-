using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using UnityEngine.SceneManagement;

public class DüşmanSpawner : MonoBehaviour
{

    [SerializeField] GameObject[] enemyPrefab;
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
                GameObject gameObject = Instantiate(enemyPrefab[Random.Range(0, enemyPrefab.Length)],
                    position, Quaternion.identity);
                yield return new WaitForSeconds(secondSpawn);
                Destroy(gameObject, 5f);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D temas)
    {
        if (temas.gameObject.tag == "karakter")
        {
           SceneManager.LoadScene(1);
            scoreGenerator.yıldızpuanı_int = 0;

        }
        if (temas.gameObject.tag == "ananasKarakter")
        {
            SceneManager.LoadScene(4);
            scoreGenerator.yıldızpuanı_int = 0;

        }
        if (temas.gameObject.tag == "drill")
        {
            SceneManager.LoadScene(6);
            scoreGenerator.yıldızpuanı_int = 0;

        }
    }
   


}

   

