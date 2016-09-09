using UnityEngine;
using System.Collections;

public class Warp : MonoBehaviour {

    public Transform warpTarget;

    IEnumerator OnTriggerEnter2D(Collider2D other) {
        ScreenFader sf = GameObject.FindGameObjectWithTag("Fader").GetComponent<ScreenFader> ();

        yield return StartCoroutine(sf.FadeToBlack()); // Fade to black screen

        Debug.Log("An object collided.");
        other.gameObject.transform.position = warpTarget.position; // reposition
        Camera.main.transform.position = warpTarget.position;

        yield return StartCoroutine(sf.FadeToClear()); // Fade to clear
    }
}
