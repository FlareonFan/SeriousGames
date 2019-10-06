using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ClickCounter : MonoBehaviour
{

public static int numOfClicks = 0;
public KeyCode mouseclick;

public GameObject PauseMenu;
public bool pauseMenuActive;





    // Start is called before the first frame update
    void Start()
{
PauseMenu.SetActive(false);
}
    

    // Update is called once per frame
    void Update()
    {

if(Input.GetKeyDown(KeyCode.P))
pauseMenuActive = !pauseMenuActive;

if(pauseMenuActive == true)
{
PauseMenu.SetActive(true);
} 
else
{
PauseMenu.SetActive(false);
}
  if(Input.GetKeyDown (mouseclick))
{
numOfClicks += 1;
    }
if (numOfClicks >=5)
{
Debug.Log("Too Many Clicks");
numOfClicks = 0;
  }
 }
}
