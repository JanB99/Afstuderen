using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LineRenderSettings : MonoBehaviour
{

    [SerializeField] LineRenderer rend;
    public GameObject panel;
    public Image image;
    public Button btn;

    Vector3[] points;

    // Start is called before the first frame update
    void Start()
    {
        rend = gameObject.GetComponent<LineRenderer>();
        points = new Vector3[2];
        points[0] = Vector3.zero;
        points[1] = transform.position + new Vector3(0,0,20);

        rend.SetPositions(points);
        rend.enabled = true;

        image = panel.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        AlignLineRenderer(rend);

        if(AlignLineRenderer(rend) && Input.GetAxis("Submit") > 0)
        {
            btn.onClick.Invoke();
        }
    }

    public LayerMask layerMask;

    public bool AlignLineRenderer(LineRenderer rend)
    {
        Ray ray;
        ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        Debug.DrawRay(ray.origin, ray.direction);
        bool hitBtn = false;

        if(Physics.Raycast(ray, out hit, layerMask))
        {
            points[1] = transform.forward + new Vector3(0,0,hit.distance);
            rend.startColor = Color.red;
            rend.endColor = Color.red;
            btn = hit.collider.gameObject.GetComponent<Button>();
            hitBtn = true;
        }
        else
        {
            points[1] = transform.forward + new Vector3(0,0,20);
            rend.startColor = Color.green;
            rend.endColor = Color.green;
            hitBtn = false;
        }
        rend.SetPositions(points);
        rend.material.color = rend.startColor;
        return hitBtn;
    }

    public void ColorChangeOnClick()
    {
        if(btn != null)
        {
            if(btn.name == "red_btn")
            {
                image.color = Color.red;
            }
            else if(btn.name == "blue_btn")
            {
                image.color = Color.blue;
            }
            else if(btn.name == "green_btn")
            {
                image.color = Color.green;
            }
        }
    }
}
