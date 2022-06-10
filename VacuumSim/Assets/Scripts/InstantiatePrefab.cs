using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiatePrefab : MonoBehaviour
{
    public Transform prefab;

    private IEnumerator spawn()
    {    
        Vector3 pos = new Vector3(0.0f, 7.5f, 0.0f);
        for (int i = 0; i < 10; i++)
        {
            yield return new WaitForSeconds(.01f);
            pos.x = Random.Range(4.5f, 5.5f);
            pos.z = Random.Range(4.5f, 5.5f);
            Instantiate(prefab, pos, Quaternion.identity);
            Debug.Log("Spawn " + prefab.name + i);
        }
        

    }

    // Start is called before the first frame update
    void Start()
    {    
        StartCoroutine(spawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
