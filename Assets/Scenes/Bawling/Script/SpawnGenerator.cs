using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SpawnGenerator : MonoBehaviour
{
    public UnityEvent onReset;
    private BoxCollider area;
    public GameObject[] propPrefabs;
    public int count = 100;
    private List<GameObject> props = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        area = GetComponent<BoxCollider>();
        for(int i = 0; i < count; i++){
            Spawn();
        }

        area.enabled = false;
    }

    // Update is called once per frame
    private void Spawn()
    {
        int selection = Random.Range(0, propPrefabs.Length);
        GameObject selectPrefab = propPrefabs[selection];
        Vector3 spawnPos = GetRandomPos();
        GameObject instance = Instantiate(selectPrefab, spawnPos, Quaternion.identity);
        props.Add(instance);
    }

    private Vector3 GetRandomPos(){
        Vector3 basePos = transform.position;
        Vector3 size = area.size;

        float posX = basePos.x + Random.Range(-size.x/2f, +size.x/2f);
        float posY = basePos.y + Random.Range(-size.y/2f, +size.y/2f);
        float posZ = basePos.z + Random.Range(-size.z/2f, +size.z/2f);
        
        Vector3 spawnPos = new Vector3(posX, posY, posZ);
        return spawnPos;
    }

    public void Reset() {
        for(int i = 0; i < props.Count; i++){
            props[i].transform.position = GetRandomPos();
            props[i].SetActive(true);
        }
    }
}
