using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TowerDeployMent : MonoBehaviour
{
    private int canvasWidth;
    private int canvasHeight;
    
    private bool isClicked;
    Ray ray;
    RaycastHit hit;
    private void Awake() {
        isClicked = false;
        canvasWidth = this.GetComponent<Camera>().pixelWidth;
        canvasHeight = this.GetComponent<Camera>().pixelHeight;
    }

    void Update() {
        if(Input.GetMouseButtonDown(0)){
            
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit, 100.0f)){
                isClicked = true;
                Vector3 targetPos = new Vector3(hit.transform.position.x, hit.transform.position.y - 0.5f, hit.transform.position.z);
                Vector3 targetDir = new Vector3(0, -1, 0);
                Ray rayBottom = new Ray(targetPos, targetDir);
                RaycastHit hitFloor;
                Physics.Raycast(rayBottom, out hitFloor, 100.0f);
                var cameraPos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
                targetPos = new Vector3(cameraPos.x * 16 - 8,
                 hitFloor.transform.position.y, cameraPos.y * (9f + (9f*Mathf.Cos(30))) - 5.175f);
                hit.transform.position = targetPos;
                var hitPos = hit.transform.position;
                Debug.Log("선택됨");
                Debug.Log("커서" + cameraPos.x + " " + cameraPos.y + " " + cameraPos.z);
                Debug.Log("타겟" + hitPos.x + " " + hitPos.y + " " + hitPos.z);

            }
        }
        if(isClicked){
            var cameraPos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
            Vector3 targetPos = hit.transform.position;
            Vector3 targetDir = new Vector3(0, -1, 0);
            Vector3 targetDirTop = new Vector3(0, 1, 0);

            

            RaycastHit hitFloor;
            RaycastHit hitTop;


            Vector3 targetTempPos = new Vector3(cameraPos.x * 16 - 8,
                hit.transform.position.y , cameraPos.y * (9f + (9f*Mathf.Cos(30))) - 5.175f);
                
            Ray rayBottom = new Ray(targetTempPos, targetDir);
            Physics.Raycast(rayBottom, out hitFloor, 100.0f);

            Ray rayTop = new Ray(targetTempPos, targetDirTop);
            Physics.Raycast(rayTop, out hitTop, 100.0f);

            if(hitTop.collider != null){
                targetPos = new Vector3(cameraPos.x * 16 - 8,
                hitTop.transform.position.y + 0.6f , cameraPos.y * (9f + (9f*Mathf.Cos(30))) - 5.175f);
                hit.transform.position = targetPos;
             Debug.Log("Ridkdkdkr" + targetPos.x + " " + targetPos.y + " " + targetPos.z);
            }
            else if(hitFloor.collider != null){
            targetPos = new Vector3(cameraPos.x * 16 - 8,
                hitFloor.transform.position.y + 0.6f , cameraPos.y * (9f + (9f*Mathf.Cos(30))) - 5.175f);
            }
            else{
                targetPos = new Vector3(cameraPos.x * 16 - 8,
                hit.transform.position.y + 0.6f, cameraPos.y * (9f + (9f*Mathf.Cos(30))) - 5.175f);
            }
            hit.transform.position = targetPos;
             Debug.Log("targetPos" + targetPos.x + " " + targetPos.y + " " + targetPos.z);
        }
    }
}
