using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickHandler : MonoBehaviour
{

//Unity 5 - How to Make A Hidden " " - Part 3 - 27/28th of Sept
//Inventory Tutorial In Unity 2919 - Beginner Friendly - 5th of October (help with getting the Pause Menu code to work)
public static string objectName;
public GameObject nameOfObject;
public Transform nameOfObjectText;
public GameObject box;

public Transform newObj;

    // Start is called before the first frame update
    void Start()
    {
        box.SetActive(false);

if(gameObject.name == "Item") 
{
GetComponent<BoxCollider> ().enabled = false;

}
    }

    // Update is called once per frame
    void Update()
    {
if ((gameObject.name=="Item") && (GetComponent<BoxCollider>().enabled == true))
{
nameOfObject.GetComponent<Text>().text = "Soup";
}
    }

void OnMouseDown()
{


if(gameObject.name == "Ramen")
{
newObj.GetComponent<BoxCollider> ().enabled = true;
}


objectName = gameObject.name;
box.SetActive(true);
Destroy (gameObject);
Destroy(nameOfObject);
ClickCounter.numOfClicks = 0;

}
}
