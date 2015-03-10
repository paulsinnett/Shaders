using UnityEngine;
using System.Collections;

public class ShaderChange : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        Color colour = Color.blue;
        colour.r = Mathf.PingPong(Time.time, 1f);
        renderer.material.SetColor("_MyColour", colour);
	}
}
