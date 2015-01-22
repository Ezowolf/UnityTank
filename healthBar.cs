using UnityEngine;
using System.Collections;

public class healthBar : MonoBehaviour
{
	
	GUIStyle style = new GUIStyle();
	Texture2D texture;
	public int healthWidth;
	Color redColor = Color.red;
	Color greenColor = Color.green;
	Color yellowColor = Color.yellow;
	public int curHealth = 100;
	
	void Start()
	{
		texture = new Texture2D(1, 1);
		texture.SetPixel(1, 1, greenColor);
	}
	
	private void Update()
	{
		
		if (curHealth > 5)
		{
			texture.SetPixel(1, 1, greenColor);
		}
		
		if (curHealth < 7)
		{
			texture.SetPixel(1, 1, yellowColor);
		}
		if (curHealth < 4)
		{
			texture.SetPixel(1, 1, redColor);
		}
	}
	
	public void OnGUI()
	{
		
		texture.Apply();
		
		style.normal.background = texture;
		GUI.Box(new Rect(0, 0, healthWidth, 20), new GUIContent(""), style);
	}
	void OnCollisionEnter(Collision coll)
	{
		if (coll.gameObject.name == "Bullet(Clone)")
		{
			curHealth--;
			healthWidth -= 200/12;
			if (curHealth <= 0)
			{
				Destroy(this.gameObject);
			}
		}
	}
}