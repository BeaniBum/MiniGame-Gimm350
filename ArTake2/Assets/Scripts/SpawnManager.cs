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
<<<<<<< Updated upstream
<<<<<<< Updated upstream
    public List<GameObject> blocks;
=======
    [SerializeField]
    private Vector3 gridSize = default;
>>>>>>> Stashed changes
=======
    [SerializeField]
    private Vector3 gridSize = default;
>>>>>>> Stashed changes

    Camera arCam;
    GameObject spawnedObject;


    // Start is called before the first frame update
    void Start(){
        spawnedObject = null;
        arCam = GameObject.Find("AR Camera").GetComponent<Camera>();
        GameObject managerObject = GameObject.Find("Manager");
        Manager managerChoice = managerObject.GetComponent<Manager>();
        //blocks = managerChoice.blockPrefabs;
    }

    // Update is called once per frame
    void Update(){
        if(Input.touchCount == 0)
        return;
        RaycastHit hit;
        Ray ray = arCam.ScreenPointToRay(Input.GetTouch(0).position);

        //takes a touch from the screen and its position in x,y on screen
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
                var position = new Vector3(
                    Mathf.Round(spawnedObject.transform.position.x / this.gridSize.x) * this.gridSize.x,
                    spawnedObject.transform.position.y,
                    Mathf.Round(spawnedObject.transform.position.z / this.gridSize.z) * this.gridSize.z);
                spawnedObject.transform.position = position;
            }
            if(Input.GetTouch(0).phase == TouchPhase.Ended){
                spawnedObject = null;
            }
        }
        
    }
    
    private void SpawnPrefab(Vector3 spawnPosition){
<<<<<<< Updated upstream
<<<<<<< Updated upstream
        GameObject managerObject = GameObject.Find("Manager");
        Manager managerChoice = managerObject.GetComponent<Manager>();
        int choice = managerChoice.choice;
        spawnedObject = Instantiate(blocks[choice], spawnPosition, Quaternion.identity);
        Debug.Log("I spawned "+ blocks[choice] +"!");
=======
=======
>>>>>>> Stashed changes
           spawnPosition = new Vector3(
            Mathf.Round(spawnPosition.x / this.gridSize.x) * this.gridSize.x,
            spawnPosition.y,
            Mathf.Round(spawnPosition.z / this.gridSize.z) * this.gridSize.z
            );
            spawnedObject = Instantiate(spawnablePrefab, spawnPosition, Quaternion.identity);
        
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
    }

   
}
