using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class QuitApplication : MonoBehaviour,IPointerExitHandler, IPointerEnterHandler
{
    public float gazeTime = 2f;
    private float timer = 0f;
    private bool gazedAt = false;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (gazedAt)
        {
            timer += Time.deltaTime;
            if (timer >= gazeTime)
            {
                Quit();
                timer = 0f;
            }

        }
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        gazedAt = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("gazedat"); gazedAt = true;
    }
    public void Quit()
    {
        Debug.Log("application Quit");
        Application.Quit();
    }
}
