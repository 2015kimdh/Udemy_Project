using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TowerDeployMent : MonoBehaviour
{
    private int canvasWidth;
    private int canvasHeight;
    float fov;
    float near;
    float far;

    public LayerMask floorLayer;
    
    private bool isClicked;
    Ray ray;
    RaycastHit hit;
    private int[] screenRatio;
    private int GetLCM(int Width, int Height){
        int temp; //나머지 저장 임시변수
        int localWidth = Width;
        int localHeight = Height;
        while(localHeight != 0)
        {
            temp = localWidth % localHeight;
            localWidth = localHeight;
            localHeight = temp;
        }
        return localWidth;
    }
    private void Awake() {
        isClicked = false;
        canvasWidth = this.GetComponent<Camera>().pixelWidth;
        canvasHeight = this.GetComponent<Camera>().pixelHeight;
        fov = this.GetComponent<Camera>().fieldOfView;
        far = this.GetComponent<Camera>().farClipPlane;
        near = this.GetComponent<Camera>().nearClipPlane;
    }

    void Update() {
        if(Input.GetMouseButtonDown(0) && isClicked == false){
            
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit, 100.0f)){
                isClicked = true;
                Vector3 targetPos = new Vector3(hit.transform.position.x, hit.transform.position.y, hit.transform.position.z);
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
        if(isClicked == true){
            var cameraPos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
            Vector3 targetPos = hit.transform.position;
            Vector3 targetDir = new Vector3(0, -1, 0);

            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hitFloor;

            Vector3 targetTempPos = new Vector3(cameraPos.x * 16 - 8,
                5.0f, cameraPos.y * (9f + (9f*Mathf.Cos(30))) - 5.175f);
                
            Ray rayBottom = new Ray(targetTempPos, targetDir);
            Physics.Raycast(rayBottom, out hitFloor, 100.0f ,floorLayer);

            if(hitFloor.collider != null){
            targetPos = new Vector3(cameraPos.x * 16 - 8,
                hitFloor.transform.position.y , cameraPos.y * (9f + (9f*Mathf.Cos(30))) - 5.175f);
            }
            else{
                targetPos = new Vector3(cameraPos.x * 16 - 8,
                targetPos.y - 0.5f, cameraPos.y * (9f + (9f*Mathf.Cos(30))) - 5.175f);
            }
            hit.transform.position = new Vector3(targetPos.x,
                targetPos.y + 0.5f, targetPos.z);
             Debug.Log("targetPos x " + targetPos.x + " y " + targetPos.y + " z " + targetPos.z);
        }
        if(Input.GetMouseButtonUp(0) && isClicked == true){
            isClicked = false;
            var cameraPos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
            Vector3 targetPos = hit.transform.position;
            Vector3 targetDir = new Vector3(0, -1, 0);

            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hitFloor;


            Vector3 targetTempPos = new Vector3(cameraPos.x * 16 - 8,
                5.0f, cameraPos.y * (9f + (9f*Mathf.Cos(30))) - 5.175f);
                
            Ray rayBottom = new Ray(targetTempPos, targetDir);
            Physics.Raycast(rayBottom, out hitFloor, 100.0f ,floorLayer);

            if(hitFloor.collider != null){
            targetPos = new Vector3(cameraPos.x * 16 - 8,
                hitFloor.transform.position.y , cameraPos.y * (9f + (9f*Mathf.Cos(30))) - 5.175f);
            }
            else{
                targetPos = new Vector3(0,
                2.0f, 0);
            }
            hit.transform.position = new Vector3(targetPos.x,
                targetPos.y+0.5f, targetPos.z);
             Debug.Log("targetPos x " + targetPos.x + " y " + targetPos.y + " z " + targetPos.z);
        }
    }
    
}
