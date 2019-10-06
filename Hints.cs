using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Hints : MonoBehaviour
{

public float rb=1f;
public float timer=0;

public static string hintSet = "n";
public static string used = "n";



public GameObject hints;

    // Start is called before the first frame update
    void Start()
    {
     hints.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
timer += Time.deltaTime;

  if ((timer >= .5) && (rb>0))
        {
            rb -= .05f;
           timer = 0;
        }

        GetComponent<SpriteRenderer>().color = new Color (rb,1,rb);
if (rb <= 0)
{ hintSet = "y";
hints.SetActive(true);
}
}

void OnMouseDown ()
{
if (hintSet == "y")
{
used = "y";
hintSet = "n";
hints.SetActive(false);
rb = 1f;
}
}
}
