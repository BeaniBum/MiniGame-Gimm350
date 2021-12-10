using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class SpawnManager : MonoBehaviour{
    [SerializeField]
    ARRaycastManager m_RaycastManager;
    List<ARRaycastHit> m_Hits = new List<ARRaycastHit>();
    [SerializeField]
    GameObject spawnablePrefab;

    Camera arCam;
    GameObject spawnedObject;
    public List<GameObject> blocks;
    public GameObject marble;


    // Start is called before the first frame update
    void Start(){
        spawnedObject = null;
        arCam = GameObject.Find("AR Camera").GetComponent<Camera>();
        GameObject managerObject = GameObject.Find("Manager");
        Manager managerChoice = managerObject.GetComponent<Manager>();
    }

    // Update is called once per frame
    void Update(){
        if(Input.touchCount == 0)
        return;
        RaycastHit hit;
        Ray ray = arCam.ScreenPointToRay(Input.GetTouch(0).position);

        if(m_RaycastManager.Raycast(Input.GetTouch(0).position,m_Hits))
        {
            //Spawns
            if(Input.GetTouch(0).phase == TouchPhase.Began && spawnedObject==null)
            {
                if(Physics.Raycast(ray, out hit))
                {
                    if (hit.collider.gameObject.tag=="Spawnable")
                    {
                        spawnedObject=hit.collider.gameObject;
                    }
                    if (hit.collider.gameObject.tag == "StartSpawn")
                    {
                        spawnedObject = hit.collider.gameObject;
                    }
                    if (hit.collider.gameObject.tag == "EndSpawn")
                    {
                        spawnedObject = hit.collider.gameObject;
                    }
                    else
                    {
                        SpawnPrefab(m_Hits[0].pose.position);
                    }
                }
            }
            //Moves
            else if(Input.GetTouch(0).phase == TouchPhase.Moved && spawnedObject !=null)
            {
                spawnedObject.transform.position = m_Hits[0].pose.position;
            }
            if(Input.GetTouch(0).phase == TouchPhase.Ended){
                spawnedObject = null;
            }
        }
        
    }

    private void SpawnPrefab(Vector3 spawnPosition){
        GameObject managerObject = GameObject.Find("Manager");
        Manager managerChoice = managerObject.GetComponent<Manager>();
        int choice = managerChoice.choice;
        spawnedObject = Instantiate(blocks[choice], spawnPosition, Quaternion.identity);
        //Debug.Log("I spawned "+ blocks[choice] +"!");
    }
}

