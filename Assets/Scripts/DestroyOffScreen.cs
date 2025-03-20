using UnityEngine;

public class DestroyOffScreenByPosition : MonoBehaviour
{
    private float leftBound, rightBound, topBound, bottomBound;

    void Start()
    {
        // Calculate the screen boundaries in world space
        Camera mainCamera = Camera.main;
        if (mainCamera != null)
        {
            float screenAspect = Screen.width / (float)Screen.height;
            float cameraHeight = mainCamera.orthographicSize * 2;
            float cameraWidth = cameraHeight * screenAspect;

            leftBound = mainCamera.transform.position.x - cameraWidth / 2;
            rightBound = mainCamera.transform.position.x + cameraWidth / 2;
            bottomBound = mainCamera.transform.position.y - mainCamera.orthographicSize;
            topBound = mainCamera.transform.position.y + mainCamera.orthographicSize;
        }
    }

    void Update()
    {
        // Check if the object is outside the boundaries
        Vector3 position = transform.position;

        if (position.x < leftBound || position.x > rightBound || position.y < bottomBound || position.y > topBound)
        {
            Destroy(gameObject);
        }
    }
}
