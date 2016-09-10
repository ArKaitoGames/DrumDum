using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class ButtonClickHandler : MonoBehaviour, IPointerClickHandler {

	private float clickTime;            // time of click
	public bool onClick = true;            // is click allowed on button?
	public bool onDoubleClick = false;    // is double-click allowed on button?

	private ClickHandler click;

	void Start() {
		click = GetComponent<ClickHandler> ();
	}

	public void OnPointerClick(PointerEventData data)
	{      
		int clickCount = 1; // single click
		
		// get interval between this click and the previous one (check for double click)
		float interval = data.clickTime - clickTime;
		
		// if this is double click, change click count
		if (interval < 1.5 && interval > 0)
			clickCount = 2;
		
		// reset click time
		clickTime = data.clickTime;
		
		// single click
		if (onClick && clickCount == 1)
		{
			// enter code here  
			print ("Clicked");
		}
		
		// double click
		if (onDoubleClick && clickCount == 2)
		{
			// enter code here
			click.OnMouseDrag();
		}
		
	}
}
