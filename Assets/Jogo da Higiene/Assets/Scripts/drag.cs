using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drag : MonoBehaviour {


	public class MouseDrag : MonoBehaviour {


		Vector3
		screenPoint,
		offset,
		scanPos,
		curPosition,
		curScreenPoint;


		float
		gridSize = 0.20f;



		void OnMouseDown() {
			scanPos = gameObject.transform.position;
			screenPoint = Camera.main.WorldToScreenPoint(scanPos);
			offset = scanPos - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));

		}




		void OnMouseDrag() {
			curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
			curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;


			curPosition.x = (float)(Mathf.Round(curPosition.x) * gridSize);

			transform.position = curPosition;
		}


	}
		
}
