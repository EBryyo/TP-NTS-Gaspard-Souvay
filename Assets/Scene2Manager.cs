using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class Scene2Manager : MonoBehaviour
{
    public ARRaycastManager raycastManager;
    public TrackableType typeToTrack = TrackableType.PlaneWithinBounds;
    public GameObject prefabToInstantiate;


    private void OnTouch()
    {
        Touch touch = Input.GetTouch(0);
        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        raycastManager.Raycast(touch.position, hits, typeToTrack);
        if (hits.Count > 0)
        {
            ARRaycastHit firstHit = hits[0];
            InstantiateObject(firstHit.pose.position, firstHit.pose.rotation);
        }
    }

    void InstantiateObject(Vector3 position, Quaternion rotation)
    {
        Instantiate(prefabToInstantiate, position, rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
            OnTouch();
    }
}
