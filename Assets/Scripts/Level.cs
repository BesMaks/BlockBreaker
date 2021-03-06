using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour {

    [SerializeField] int breakableBlocks;

    SceneLoader sceneLoader;

    private void Start() {
        sceneLoader = FindObjectOfType<SceneLoader>();
    }

    public void CountBreakableBlocks() {
        breakableBlocks++;
    }

    public void blockDestroyed() {
        breakableBlocks--;
        if (breakableBlocks <= 40) {
            sceneLoader.LoadNextScene();
        }
    }
}
