using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject pipePreFab;
    [SerializeField] float spawnInterval = 5f;
// Start is called before the first frame update
void Start()
    {
        StartCoroutine(Spawnpipes());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Spawnpipes()
    {
        while (true) 
        {
            Vector3 spawnPos = new Vector3(transform.position.x, transform.position.y + Random.Range(-3f,3f), transform.position.z);
            Instantiate(pipePreFab, spawnPos, Quaternion.identity);
            spawnInterval = Random.Range(1f, 4f);
            yield return new WaitForSeconds(spawnInterval);


        }
    
    
    }
}
