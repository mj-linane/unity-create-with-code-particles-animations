﻿using UnityEngine;

namespace Challenge_3.Scripts
{
    public class MoveLeftX : MonoBehaviour
    {
        public float speed;
        private const float leftBound = -10;
        private PlayerControllerX playerControllerScript;

        // Start is called before the first frame update
        private void Start()
        {
            playerControllerScript = GameObject.Find("Player").GetComponent<PlayerControllerX>();
        }

        // Update is called once per frame
        private void Update()
        {
            // If game is not over, move to the left
            if (!playerControllerScript.gameOver)
                transform.Translate(Vector3.left * (speed * Time.deltaTime), Space.World);

            // If object goes off screen that is NOT the background, destroy it
            if (transform.position.x < leftBound && !gameObject.CompareTag("Background")) Destroy(gameObject);
        }
    }
}