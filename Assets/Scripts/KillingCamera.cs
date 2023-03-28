using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class KillingCamera : MonoBehaviour
{

    // Ce script est repris du sujet du TP2. Il permet a l'utilisateur de détruire des objets en appuyant dessus. Un compteur a été ajouté pour la gestion du score.


    public GameObject particleEffect;
    private Vector2 touchpos;
    private RaycastHit hit;
    private Camera cam;
    private int count;
    public TextMeshProUGUI scoreCounter;

    void Start()
    {
        scoreCounter.text = "Score : 0";
        cam = GetComponent<Camera>();
    }

    void Update()
    {
        if (Input.touchCount <= 0)
            return;
        touchpos = Input.GetTouch(0).position;
        Ray ray = cam.ScreenPointToRay(touchpos);
        if (Physics.Raycast(ray,out hit))
        {
            var hitObj = hit.collider.gameObject;
            if (hitObj.tag == "Ball")
            {
                var clone = Instantiate(particleEffect, hitObj.transform.position, Quaternion.identity);
                clone.transform.localScale = hitObj.transform.localScale;
                Destroy(hitObj);
                count++;
                scoreCounter.text = $"Score : {count}";
            }
        }
    }
}
