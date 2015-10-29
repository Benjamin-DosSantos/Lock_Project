using UnityEngine;
using System.Collections;

public class Background_Draw : MonoBehaviour {
	public Texture lockTop;
	public Texture lockBody;
	public Color bgColor;
	Camera cam;
	void Start(){
		setupCam();
		drawBackground();
	}//End of Start Method

	void OnGUI(){
		if(!lockTop || !lockBody){
			Debug.LogError("One or more of the textures to be drawn were not assigned. Assign a texture in the inspector.");
		}else{
			// Arguments in order used: Position_x, Position_y, Width, Height, Image
			GUI.DrawTexture(new Rect(20, 20, 60, 60), lockTop);
			GUI.DrawTexture(new Rect(20, 20, 60, 60), lockBody);
		}//of if check for textures
	}//end of OnGUI method

	void setupCam(){
		cam = GetComponent<Camera>();
		cam.clearFlags = CameraClearFlags.SolidColor;
	}//end of setupCam method

	Color getBackgroundColor(){
		return bgColor;
	}//end of getBackgroundColor method

	void setBackgoundColor(Color newColor){
		bgColor = newColor;
	}//end of setBackgroundColor method

	void drawBackground(){
		cam.backgroundColor = bgColor;
	}//end of drawBackground method
}// End of class
